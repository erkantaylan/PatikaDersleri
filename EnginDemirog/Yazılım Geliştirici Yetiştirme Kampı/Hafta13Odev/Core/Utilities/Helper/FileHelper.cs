using System;
using System.IO;
using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Helper
{
    public class FileHelper
    {
        private static readonly string CurrentFileDirectory = Environment.CurrentDirectory + "\\wwwroot";
        private static readonly string FolderName = "\\images\\";

        public static IResult Add(IFormFile file)
        {
            IResult fileExist = CheckFileExists(file);
            if (fileExist.Message != null) return new ErrorResult(fileExist.Message);

            var type = Path.GetExtension(file.FileName);
            IResult typeValid = CheckFileTypeValid(type);
            var randomName = Guid.NewGuid().ToString();

            if (typeValid.Message != null) return new ErrorResult(typeValid.Message);

            CheckFileDirectoryExist(CurrentFileDirectory + FolderName);
            CreateImageFile(CurrentFileDirectory + FolderName + randomName + type, file);
            return new SuccessResult((FolderName + randomName + type).Replace("\\", "/"));
        }

        public static IResult Update(string imagePath, IFormFile file)
        {
            IResult fileExist = CheckFileExists(file);
            if (fileExist.Message != null) return new ErrorResult(fileExist.Message);

            var type = Path.GetExtension(file.FileName);
            IResult typeValid = CheckFileTypeValid(type);
            var randomName = Guid.NewGuid().ToString();

            if (typeValid.Message != null) return new ErrorResult(typeValid.Message);

            DeleteOldImageFile((CurrentFileDirectory + imagePath).Replace("/", "\\"));
            CheckFileDirectoryExist(CurrentFileDirectory + FolderName);
            CreateImageFile(CurrentFileDirectory + FolderName + randomName + type, file);

            return new SuccessResult((FolderName + randomName + type).Replace("\\", "/"));
        }

        public static IResult Delete(string path)
        {
            DeleteOldImageFile((CurrentFileDirectory + path).Replace("/", "\\"));
            return new SuccessResult();
        }


        //Verification Methods

        private static IResult CheckFileTypeValid(string type)
        {
            if (type != ".jpeg" && type != ".png" && type != ".jpg") return new ErrorResult("File Type Is Wrong!");

            return new SuccessResult();
        }

        private static IResult CheckFileExists(IFormFile file)
        {
            if (file != null && file.Length > 0) return new SuccessResult();
            return new ErrorResult("File Not Found!");
        }

        private static void DeleteOldImageFile(string directory)
        {
            if (File.Exists(directory.Replace("/", "\\"))) File.Delete(directory.Replace("/", "\\"));
        }

        private static void CheckFileDirectoryExist(string directory)
        {
            if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
        }

        private static void CreateImageFile(string directory, IFormFile file)
        {
            using FileStream fs = File.Create(directory);
            file.CopyTo(fs);
            fs.Flush();
        }
    }
}