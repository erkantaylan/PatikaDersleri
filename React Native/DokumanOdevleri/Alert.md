## Alert
***
Başlığı ve mesajı olan uyarıları yada onay almak için kullanılan iletişim kutusu başlatır. İsteğe bağlı olarak düğme listesi sağlayabiliyorsunuz. Açılan iletişim kutusunda herhangi bir düğmeye dokunduğunda ilgili onPress callBack'i tetikler ve pencereyi kapatır. 
Varsayılan olarak iletişim kutusu penceresinde 'Tamam(Ok)' düğmesi olmaktadır.
Hem Android hem de iOS üzerinde çalışan ve statik uyarılar gösterebilen bir API'dir. iOS'ta yalnızca kullanıcıdan bazı bilgileri girmesini isteyen uyarı mevcuttur.
Example
```JS


```
iOS
iOS'ta istediğiniz sayıda button belirleyebilirsiniz. Her button isteğe bağlı olarak stil belirlenebilir, mevcut seçenekler AlertButtonStyle enum ile temsil edilir.
Android
Android'de en fazla üç düğme belirtilebilir. Androide kulllanılan konsepler ise neutral(Nötr), negative(Negatif) ve positive(Pozitif) buttonlarıdır:
1. Eğer bir buton kullanılıyorsa kullanılan konsept 'positive(pozitif)' olmalıdır('Ok' yada 'Tamam' gibi).
2. Eğer iki buton kullanılıyorsa kullanılan konsept 'negative(Negatif)'ve 'positive(pozitif)' olmalıdır('Ok(Tamam)' ve 'Cancel(İptal)' gibi).
