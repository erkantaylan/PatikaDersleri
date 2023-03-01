# Javascript Notları 

## DOM işlemleri  

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<ul id="alan"><li>Volkan Alakent</li>
	<li>Javascript Eğitim Seti</li>
</ul>
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// firstChild		:	Belge içerisindeki herhangi bir HTML elemanının içerdiği ilk alt node'u (düğümü) elde etmek için kullanılır.
var deger	=	document.getElementById("alan").firstChild;
var deger	=	document.getElementById("alan").firstChild.nodeName;
var deger	=	document.getElementById("alan").firstChild.nodeName;
var deger	=	document.getElementById("alan").firstChild.innerHTML;
document.getElementById("sonuc").innerHTML = deger;

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<div id="alan">
	<div>Javascript</div>
	<div>Css</div>
	<div>Html</div>
	<div>Php</div>
	<div>Python</div>
</div><br />

<script type="text/javascript" language="javascript">
// lastElementChild 	:	Belge içerisindeki herhangi bir HTML elemanının içerdiği son elemanı elde etmek için kullanılır.
var deger	=	document.getElementById("alan").lastElementChild;
var deger	=	document.getElementById("alan").lastElementChild.tagName;
var deger	=	document.getElementById("alan").lastElementChild.innerHTML;
document.getElementById("sonuc").innerHTML = deger;
document.getElementById("alan").lastElementChild.style.color = "blue";

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<div id="kimlik"><div>Volkan Alakent</div><div>Javascript</div><div>Eğitim Seti</div><!-- Gizli Açıklama --></div><br />
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// lastChild	:	Belge içerisindeki herhangi bir HTML elemanının içerisindeki son alt node'u (düğümü) elde etmek için kullanılır.
var deger	=	document.getElementById("kimlik").lastChild;
var deger	=	document.getElementById("kimlik").lastChild.nodeName;
var deger	=	document.getElementById("kimlik").lastChild.innerHTML;
document.getElementById("sonuc").innerHTML = deger;

</script>
</body>
</html>
```
```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<div>
	<p id="bir">Javascript</p>
    <div id="iki">PHP</div>
	<p id="uc">HTML</p>
    <div id="dort">JQuery</div>
	<p id="bes">CSS</p>
</div><br /><br /><br />
<div id="sonuc"></div>


<script type="text/javascript" language="javascript">
// nextElementSibling 	:	Belge içerisindeki herhangi bir HTML elemanının içerisindeki aynı seviyede yani kardeş olan elemanlardan, belirtilecek olan elemandan sonra gelen ilk elemanı elde etmek için kullanılır.

var deger	=	document.getElementById("bir").nextElementSibling;
var deger	=	document.getElementById("dort").nextElementSibling;
var deger	=	document.getElementById("uc").nextElementSibling.innerHTML;
var deger	=	document.getElementById("uc").nextElementSibling.tagName;
var deger	=	document.getElementById("uc").nextElementSibling.id;
document.getElementById("sonuc").innerHTML = deger;

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<div>
	<p id="birincieleman">Javascript</p>
    <div id="ikincieleman">PHP</div>
	<p id="ucuncueleman">CSS</p>
    <div id="dorduncueleman">HTML</div>
	<p id="besincieleman">JQuery</p>
    <div id="altincieleman">XML</div>
</div>
<br /><br /><br />
<div id="sonucalani"></div>

<script type="text/javascript" language="javascript">
// nextSibling	:	Belge içerisindeki herhangi bir HTML elemanının içerisindeki aynı seviyede yani kardeş olan node'lardan (düğümlerden), belirtilecek olan node'dan (düğümden) sonra gelen ilk node'u (düğümü) elde etmek için kullanılır.

var sonuc	=	document.getElementById("ucuncueleman").nextSibling;
var sonuc	=	document.getElementById("ucuncueleman").nextSibling.tagName;
var sonuc	=	document.getElementById("ucuncueleman").nextSibling.id;
document.getElementById("sonucalani").innerHTML = sonuc;
document.getElementById("ucuncueleman").nextSibling.style.color = "red";

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<div>
	<div id="aaa">Javascript</div>
    <p id="bbb">Php</p>
	<div id="ccc">Html</div>
    <p id="ddd">Css</p>
	<div id="eee">Jquery</div>
    <p id="fff">Xml</p>
	<div id="ggg">Python</div>
</div>
<br /><br /><br />
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// previousElementSibling 	:	Belge içerisindeki herhangi bir HTML elemanının içerisindeki aynı seviyede yani kardeş olan elemanlardan, belirtilecek olan elemandan önce gelen ilk elemanı elde etmek için kullanılır.
var sonuc	=	document.getElementById("ccc").previousElementSibling;
var sonuc	=	document.getElementById("ddd").previousElementSibling.tagName;

var sonuc	=	document.getElementById("ddd").previousElementSibling.id;
document.getElementById("sonuc").innerHTML = sonuc;
document.getElementById("ddd").previousElementSibling.style.backgroundColor = "grey";
document.getElementById("ddd").previousElementSibling.style.color = "white";
</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<ol><li id="bir">Javascript</li><li id="iki">Css</li><li id="uc">Html</li><li id="dort">Php</li><li id="bes">Xml</li></ol>
<br /><br /><br />
<div id="sonucalani"></div>

<script type="text/javascript" language="javascript">
// previousSibling	:	Belge içerisindeki herhangi bir HTML elemanının içerisindeki aynı seviyede yani kardeş olan node'lardan (düğümlerden), belirtilecek olan node'dan (düğümden) önce gelen ilk node'u (düğümü) elde etmek için kullanılır.

var sonuc	=	document.getElementById("uc").previousSibling;
var sonuc	=	document.getElementById("uc").previousSibling.nodeName;
var sonuc	=	document.getElementById("uc").previousSibling.nodeName;
var sonuc	=	document.getElementById("uc").previousSibling.innerHTML;
document.getElementById("sonucalani").innerHTML = sonuc;
document.getElementById("uc").previousSibling.style.fontWeight = "bold";
document.getElementById("uc").previousSibling.style.color = "blue";


</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<div id="deneme"><span id="yazilimdili"><b id="kalinlastir">Java</b>script</span> Eğitim Seti</div>
<br /><br />
<div id="sonucalani"></div>

<script type="text/javascript" language="javascript">
// offsetParent 	:	Belge içerisindeki herhangi bir HTML elemanının içerisinde mutlak olarak konumlandırıldığı ilk elemanın referans nesnesini elde etmek için kullanılır.

var bul	=	document.getElementById("kalinlastir").offsetParent;
document.getElementById("sonucalani").innerHTML = bul;

</script>
</body>
</html>
```
```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<div id="alan">
	<p id="bir">Javascript Eğitim Seti</p>
	<p id="iki">Php Eğitim Seti</p>
</div>
<br /><br />
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// contains() 	:	Belge içerisindeki herhangi bir node'un (düğümün), başka bir node'un (düğümün) alt node'u düğümü olup olmadığını kontrol ederek, boolean (mantıksal) veri türünde sonucu geriye döndürür.

var kontrol		=	document.getElementById("alan");
var islemyap	=	document.getElementById("bir").contains(kontrol);
var kontrol		=	document.getElementById("bir");
var islemyap	=	document.getElementById("alan").contains(kontrol);
document.getElementById("sonuc").innerHTML = islemyap;

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<button onclick="ornek()">Tıklayınız</button>
<br /><br />

<ul id="liste">
	<li>Javascript</li>
	<li>Php</li>
	<li>Html</li>
</ul>

<br /><br />
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// textContent 	:	Belge içerisindeki herhangi bir node'un (düğümün), text node'larının (metin düğümlerinin) değerini elde etmek veya ayarlamak için kullanılır.

function ornek(){
	var deger	=	document.getElementById("alan").textContent;
	var deger	=	document.getElementById("deneme").textContent;
	document.getElementById("alan").textContent = "Volkan Alakent";
	document.getElementById("deneme").textContent = "Yeni Düğüm";
	var deger	=	document.getElementById("liste").textContent;
	var deger	=	document.getElementById("liste").innerHTML;
	document.getElementById("sonuc").innerHTML = deger;
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<div id="jsdugumu">Javascript</div>
<div id="cssdugumu">Css</div>
<div id="htmldugumu">Html</div>
<div id="phpdugumu">Php</div>
<br /><br />
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// compareDocumentPosition() 	:	Belge içerisinde bulunan node'ların (düğümlerin) birbilerine göre konum değerlerini elde etmek için kullanılır.
// 2	:	Belirtilen ilk düğüm, belirtilen ikinci düğümden sonra
// 4	:	Belirtilen ilk düğüm, belirtilen ikinci düğümden önce

var ilkdugum	=	document.getElementById("phpdugumu");
var ikincidugum	=	document.getElementById("cssdugumu");
var islemyap	=	ilkdugum.compareDocumentPosition(ikincidugum);
document.getElementById("sonuc").innerHTML = islemyap;

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>

<div>
	<div id="ornekbir">Javascript Eğitim Seti</div>
	<div id="ornekiki">HTML Eğitim Seti</div>
	<div id="ornekuc">CSS Eğitim Seti</div>
	<div id="ornekdort">PHP Eğitim Seti</div>
</div>
<br /><br />
<div id="sonucalani"></div>

<script type="text/javascript" language="javascript">
// parentElement	:	Belge içerisindeki herhangi ibr HTML elemanının bir üst elemanını elde etmek için kullanılır.

var sonuc	=	document.getElementById("ornekuc").parentElement;
var sonuc	=	document.getElementById("ornek").parentElement;
document.getElementById("sonucalani").innerHTML = sonuc;
document.getElementById("ornekuc").style.backgroundColor = "yellow";
document.getElementById("ornekuc").parentElement.style.backgroundColor = "yellow";
document.getElementById("ornekuc").parentElement.parentElement.style.backgroundColor = "yellow";

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<!-- Deneme İçin Gizli HTML Açıklama Alanı -->
<div>
	<div id="ornekbir">Javascript Eğitim Seti</div>
	<div id="ornekiki">Php Eğitim Seti</div>
    <!-- Deneme İçin Gizli HTML Açıklama Alanı -->
	<div id="ornekuc">Css Eğitim Seti</div>
	<div id="ornekdort">Xml Eğitim Seti</div>
</div>
<br /><br />
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// parentNode	:	Belge içerisindeki herhangi bir node'un (düğümün) bir üst node'unu (düğümünü) elde etmek için kullanılır.

var deger	=	document.getElementById("ornek").parentNode;
var deger	=	document.getElementById("ornekuc").parentNode;
var deger	=	document.getElementById("ornekuc").parentNode.parentNode;
document.getElementById("sonuc").innerHTML = deger;

document.getElementById("ornekuc").style.backgroundColor = "yellow";
document.getElementById("ornekuc").parentNode.style.backgroundColor = "yellow";
document.getElementById("ornekuc").parentNode.parentNode.style.backgroundColor = "yellow";

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<button onclick="ornekbir()">Birinci Listeye Ekle</button>
<button onclick="ornekiki()">İkinci Listeye Ekle</button>
<br /><br /><br /><br />
<ul id="bir">
	<li>Javascript</li>
	<li>HTML</li>
	<li>CSS</li>
	<li>PHP</li>
</ul>
<br /><br /><br /><br />
<ul id="iki">
	<li>Photoshop</li>
	<li>Corel</li>
	<li>Paint</li>
	<li>Paint.NET</li>
</ul>

<script type="text/javascript" language="javascript">
// appendChild() 	:	Bir node'u (düğümü) belge içerisinde belirtilecek olan herhangi bir elemanın içerisine en sonda olmak üzere eklemek için kullanılır.

function ornekbir(){
	var elemanolustur	=	document.createElement("LI");
	var icerikolustur	=	document.createTextNode("XML");
	elemanolustur.appendChild(icerikolustur);
	document.getElementById("bir").appendChild(elemanolustur);
}

function ornekiki(){
	var elemanolustur	=	document.createElement("LI");
	var icerikolustur	=	document.createTextNode("IrfanView");
	elemanolustur.appendChild(icerikolustur);
	document.getElementById("iki").appendChild(elemanolustur);
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<button onclick="ornek()">Sil</button>
<br /><br />
<ol id="liste">
	<li id="bir">Javascript</li>
	<li id="iki">Php</li>
	<li id="uc">Xml</li>
	<li id="dort">Css</li>
	<li id="bes">Html</li>
</ol>

<script type="text/javascript" language="javascript">
// removeChild()		:	Belge içerisindeki herhangi bir HTML elemanının içerdiği node'u (düğümü) kaldırmak / silmek için kullanılır.

function ornek(){
    var islem	=	document.getElementById("liste");
	islem.removeChild(document.getElementById("uc"));

	var islem	=	document.getElementById("liste");
	islem.removeChild(islem.childNodes[5]);
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<button onclick="ornek()">Değiştir</button>
<br /><br />
<ul id="liste">
	<li id="bir">Php</li>
	<li id="iki">Html</li>
	<li id="uc">Css</li>
	<li id="dort">Xml</li>
</ul>

<script type="text/javascript" language="javascript">
// replaceChild() 	:	Belge içerisindeki herhangi bir HTML elemanının içerdiği node'u (düğümü) değiştirmek için kullanılır.

function ornek(){
	var yenieleman	=	document.createElement("LI");
	var yenidugum	=	document.createTextNode("Javascript");
	yenieleman.appendChild(yenidugum);
	
	var deger		=	document.getElementById("liste");
	deger.replaceChild(yenieleman, deger.childNodes[3]);
}

</script>
</body>
</html>
```
```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<ul id="listebir">
	<li id="abir">Javascript</li>
	<li id="aiki">Php</li>
	<li id="auc">Css</li>
</ul>
<br /><br />
<button onclick="ornek()">Kopyala</button>


<script type="text/javascript" language="javascript">
// cloneNode() 		:	Belge içerisindeki herhangi bir HTML elemanının içerdiği node'u (düğümü) kopyalamak için kullanılır.

function ornek(){
    var kopyalanacakdugum	=	document.getElementById("listebir").childNodes[1];
	var kopyalanacakdugum	=	document.getElementsByTagName("UL")[0];
	var kopyala				=	kopyalanacakdugum.cloneNode(true);
	document.body.appendChild(kopyala);
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<button onclick="ornek()">Ekle</button>
<br /><br />
<ul id="listebir"><li>Javascript</li><li>Php</li><li>Css</li></ul>
<br /><br />
<ul id="listeiki"><li>Html</li><li>Xml</li><li>JQuery</li></ul>

<script type="text/javascript" language="javascript">
// insertBefore() 	:	Bir node'u (düğümü) belge içerisndeki belirtilecek olan herhangi bir node'un (düğümün) önüne eklemek için kullanılır.

function ornek(){
	var islembir	=	document.getElementById("listeiki").lastChild;
	var islemiki	=	document.getElementById("listebir");
	var yer			=	islemiki.childNodes[0];
	islemiki.insertBefore(islembir, yer);
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<div id="ornek">Javascript Eğitim Seti</div>
<br /><br />
<div id="sonucalani"></div>

<script type="text/javascript" language="javascript">
// hasAttribute() 		:	Belge içerisindeki herhangi bir HTML elemanının belirtilen özelliğe sahip olup olmadığını kontrol ederek, boolean (mantıksal) veri türünde sonucu geriye döndürür.

var kontrolet	=	document.getElementById("ornek").hasAttribute("name");
if(kontrolet==true){
	document.getElementById("sonucalani").innerHTML = "Belirttiğiniz özellik ilgili HTML elemanında bulunmaktadır.";
}else{
	document.getElementById("sonucalani").innerHTML = "Belirttiğiniz özellik ilgili HTML elemanında yoktur.";
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<div contenteditable="true">Javascript Eğitim Seti</div>
<br /><br />
<div id="sonucalani"></div>

<script type="text/javascript" language="javascript">
// hasAttributes() 		:	Belge içerisindeki herhangi bir HTML elemanının herhangi bir özelliğe sahip olup olmadığını kontrol ederek, boolean (mantıksal) veri türünde sonucu geriye döndürür.

var kontrol		=	document.getElementsByTagName("DIV")[0].hasAttributes();
if(kontrol==true){
	document.getElementById("sonucalani").innerHTML = "İlgili HTML elemanının global bir özelliği vardır.";
}else{
	document.getElementById("sonucalani").innerHTML = "İlgili HTML elemanının global bir özelliği yoktur.";
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
<style>
.orneksinif{
	color:red;
}
</style>
</head>

<body>
<div id="ornek" name="deneme" style="font-weight:bold; font-size:25px;" class="orneksinif" contenteditable="true">Javascript Eğitim Seti</div>
<br /><br />
<div id="sonucbir"></div>
<div id="sonuciki"></div>
<div id="sonucuc"></div>
<div id="sonucdort"></div>
<div id="sonucbes"></div>

<script type="text/javascript" language="javascript">
// getAttribute() 		:	Belge içerisindeki herhangi bir HTML elemanının belirtilen özelliğinin değerini elde etmek için kullanılır.

var birincideger	=	document.getElementsByTagName("DIV")[0].getAttribute("id");
var ikincideger		=	document.getElementsByTagName("DIV")[0].getAttribute("name");
var ucuncudeger		=	document.getElementsByTagName("DIV")[0].getAttribute("style");
var dorduncudeger	=	document.getElementsByTagName("DIV")[0].getAttribute("class");
var besincideger	=	document.getElementsByTagName("DIV")[0].getAttribute("contenteditable");

document.getElementById("sonucbir").innerHTML = "id değeri : " + birincideger;
document.getElementById("sonuciki").innerHTML = "name değeri : " + ikincideger;
document.getElementById("sonucuc").innerHTML = "style değeri : " + ucuncudeger;
document.getElementById("sonucdort").innerHTML = "class değeri : " + dorduncudeger;
document.getElementById("sonucbes").innerHTML = "contenteditable değeri : " + besincideger;

</script>
</body>
</html>
```
```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<a id="baglanti" href="https://www.google.com.tr" target="_blank">Link'e Git</a>
<br /><br />
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// getAttributeNode() 		:	Belge içerisindeki herhangi bir HTML elemanının belirtilen özellik node'unun (düğümünün) değerini elde etmek veya ayarlamak için kullanılır.

var degerbul	=	document.getElementById("baglanti").getAttributeNode("href").value = "https://www.yandex.com.tr";
document.getElementById("sonuc").innerHTML = degerbul;

document.getElementById("baglanti").getAttributeNode("href").value = "https://www.yandex.com.tr";
document.getElementById("baglanti").getAttributeNode("target").value = "_top";
</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<button onclick="ornek()">Ekle</button>
<br /><br />
<a id="baglanti" target="_blank">Bağlantıya Git</a>

<script type="text/javascript" language="javascript">
// setAttribute() 	:	Belge içerisindeki herhangi bir HTML elemanına belirtilen özelliği ve değerini eklemek için kullanılır.

function ornek(){
	document.getElementById("deneme").setAttribute("type", "button");

	document.getElementById("baglanti").setAttribute("href", "https://www.google.com.tr");
	document.getElementById("baglanti").setAttribute("style", "color:red");
	
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<button onclick="ornek()">Tıklayınız</button>
<br /><br />
<a id="baglanti">Bağlantıya Git</a>

<script type="text/javascript" language="javascript">
// setAttributeNode() 	:	Belge içerisindeki herhangi bir HTML elemanına createAttribute() metodu ile oluşturulan özellik node'unu (düğümünü) ve değerini, node object'ine (düğüm nesnesine) uygulamak için kullanılır.

function ornek(){
	var baglan					=	document.getElementById("baglanti");
	var eklenecekozellikbir		=	document.createAttribute("href");
	eklenecekozellikbir.value 	=	"https://www.google.com.tr";
	var eklenecekozellikiki		=	document.createAttribute("target");
	eklenecekozellikiki.value 	=	"_top";
	var eklenecekozellikuc		=	document.createAttribute("style");
	eklenecekozellikuc.value 	=	"color:blue; font-size:25px;";
	baglan.setAttributeNode(eklenecekozellikbir);
	baglan.setAttributeNode(eklenecekozellikiki);
	baglan.setAttributeNode(eklenecekozellikuc);
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
<style>
.deneme{
	text-decoration:none;
	color:#FF9900;
	font-weight:bold;
	font-size:18px;
}
</style>
</head>

<body>
<button onclick="ornek()">İşlem Yap</button>
<br /><br />
<a id="ornek" href="https://www.google.com.tr" target="_blank" class="deneme">Google</a>

<script type="text/javascript" language="javascript">
// removeAttribute() 	:	Belge içerisindeki herhangi bir HTML elemanının belirtilen özelliğini kaldırmak / silmek için kullanılır

function ornek(){
	document.getElementById("ornek").removeAttribute("class");
	document.getElementById("ornek").removeAttribute("href");
	document.getElementById("ornek").removeAttribute("target");
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
<style>
.deneme{
	width:300px;
	height:20px;
	background-color:yellow;
	border:1px solid black;
	text-align:center;
}
</style>
</head>

<body>
<button onclick="ornek()">İşlem Yap</button>
<br /><br />
<p id="alan" class="deneme">Javascript Eğitim Seti</p>

<script type="text/javascript" language="javascript">
// removeAttributeNode() 	:	Belge içerisindeki herhangi bir HTML elemanına getAttributeNode() metodu ile belirtilmiş özellik node'unu (düğümünü), node object'inden (düğüm nesnesinden) kaldırmak / silmek için kullanılır.

function ornek(){
	var deger				=	document.getElementById("alan");
	var kaldiralacakdugum	=	deger.getAttributeNode("class");
	deger.removeAttributeNode(kaldiralacakdugum);
}
function ornek(){
	var deger					=	document.getElementById("baglanti");
	var kaldiralacakdugumbir	=	deger.getAttributeNode("href");
	var kaldiralacakdugumiki	=	deger.getAttributeNode("target");
	deger.removeAttributeNode(kaldiralacakdugumbir);
	deger.removeAttributeNode(kaldiralacakdugumiki);
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
<style>
.ornek{
	width:200px;
	padding:10px;
	border-left:50px solid black;
	border-top:10px solid black;
}
</style>
</head>

<body>
<div id="alan" class="ornek">JAVASCRIPT EĞİTİM SETİ</div>
<br /><br />
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// clientLeft 	:	Belge içerisindeki herhangi bir HTML elemanının sol kenarlık genişliği değerini elde etmek için kullanılır.
// clientTop 	:	Belge içerisindeki herhangi bir HTML elemanının üst kenarlık yüksekliği değerini elde etmek için kullanılır.

var solkenarlikdegeri	=	document.getElementById("alan").clientLeft;
var ustkenarlikdegeri	=	document.getElementById("alan").clientTop;
document.getElementById("sonuc").innerHTML = "Sol kenarlık genişliği : " + solkenarlikdegeri + "px, Üst kenarlık yüksekliği : " + ustkenarlikdegeri + "px";

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
<style>
.ornek{
	width:70px;
	height:50px;
	background-color:yellow;
	padding-top:25px;
	padding-left:25px;
}
</style>
</head>

<body>
<div id="alan" class="ornek">Javascript</div>
<br /><br />
<div id="bir"></div>
<div id="iki"></div>

<script type="text/javascript" language="javascript">
// clientWidth 		:	Belge içerisindeki herhangi bir HTML elemanının içerik genişliği değerini elde etmek için kullanılır.
// clientHeight 	:	Belge içerisindeki herhangi bir HTML elemanının içerik yüksekliği değerini elde etmek için kullanılır.
/*
Hesaplama
Genişlik 			:	padding-left + genişlik + padding-right
Yükseklik 			:	padding-top + yükseklik + padding-bottom
*/

var degerbir	=	document.getElementById("alan").clientWidth;
var degeriki	=	document.getElementById("alan").clientHeight;
document.getElementById("bir").innerHTML = "Elemanın içerik genişliği : " + degerbir + "px";
document.getElementById("iki").innerHTML = "Elemanın içerik yüksekliği : " + degeriki + "px";

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
<style>
.ornek{
	width:300px;
	height:100px;
	border:1px solid black;
	background-color:red;
	margin-top:100px;
	margin-left:100px;
}
</style>
</head>

<body style="margin:0;">
<br /><br /><br /><br />
<div id="alan" class="ornek"></div>
<br /><br />
<div id="sonucbir"></div>
<div id="sonuciki"></div>

<script type="text/javascript" language="javascript">
// offsetLeft 		:	Belge içerisindeki herhangi bir HTML elemanının sol üst köşesi ile browser (tarayıcı) penceresinin sol üst köşesi arasındaki yatay uzaklık farkı değerini elde etmek için kullanılır.
// offsetTop 		:	Belge içerisindeki herhangi bir HTML elemanının sol üst köşesi ile browser (tarayıcı) penceresinin sol üst köşesi arasındaki dikey uzaklık farkı değerini elde etmek için kullanılır.

var degerbir	=	document.getElementById("alan").offsetLeft;
var degeriki	=	document.getElementById("alan").offsetTop;
document.getElementById("sonucbir").innerHTML = "Yatay uzaklık farkı : " + degerbir + "px";
document.getElementById("sonuciki").innerHTML = "Dikey uzaklık farkı : " + degeriki + "px";

</script>
</body>
</html>
```
```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
<style>
.ornek{
	width:800px;
	height:600px;
	border:5px double blue;
	background-color:#F1F1F1;
	padding-top:25px;
	padding-left:20px;
	padding-right:15px;
	padding-bottom:10px;
}
</style>
</head>

<body>
<div id="alan" class="ornek"></div>
<br /><br />
<div id="sonucbir"></div>
<div id="sonuciki"></div>

<script type="text/javascript" language="javascript">
// offsetWidth 		:	Belge içerisindeki herhangi bir HTML elemanının genişlik değerini elde etmek için kullanılır.
// offsetHeight 	:	Belge içerisindeki herhangi bir HTML elemanının yükseklik değerini elde etmek için kullanılır.
/*
Hesaplama :
Genişlik			:	border-left + padding-left + genişlik + padding-right + border-right;
Yükseklik			:	border-top + padding-top + yükseklik + padding-bottom + border-bottom;
*/

var degerbir	=	document.getElementById("alan").offsetWidth;
var degeriki	=	document.getElementById("alan").offsetHeight;
document.getElementById("sonucbir").innerHTML = "Elemanın genişliği " + degerbir + "px'dir.";
document.getElementById("sonuciki").innerHTML = "Elemanın yüksekliği " + degeriki + "px'dir.";

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
<style>
.bir{
	background-color:#FF9900;
	width:500px;
	height:500px;
	overflow:auto;
}
.iki{
	width:2000px;
	height:2000px;
	padding:20px;
	background-color:yellow;
}
</style>
</head>

<body>
<div id="kapsayici" class="bir" onscroll="ornek()">
	<div id="alan" class="iki">Javascript</div>
</div>
<br /><br />
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// scrollLeft 		:	Belge içerisindeki herhangi bir HTML elemanının yatay kaydırılma genişliği pixel değerini elde etmek için kullanılır.
// scrollTop 		:	Belge içerisindeki herhangi bir HTML elemanının dikey kaydırılma genişliği pixel değerini elde etmek için kullanılır.
/*
Hesaplama : 
Yatay (Genişlik) 	:	margin-left + border-left + padding-left + genişlik + padding-right + border-right + margin-right
Dikey (Yükseklik) 	:	margin-top + border-top + padding-top + yükseklik + padding-bottom + border-bottom + margin-bottom
*/

function ornek(){
	var degerbir	=	document.getElementById("kapsayici").scrollLeft;
	var degeriki	=	document.getElementById("kapsayici").scrollTop;
	document.getElementById("sonuc").innerHTML = "Yatay Kaydırılma Değeri : " + degerbir + "px'dir. Dikey Kaydırılma Değeri : " + degeriki + "px'dir";
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
<style>
.bir{
	background-color:yellow;
	width:800px;
	height:600px;
	overflow:auto;
}
.iki{
	background-color:#F1F1F1;
	width:5000px;
	height:4000px;
	padding-left:10px;
	padding-top:15px;
	padding-right:20px;
	padding-bottom:25px;
}
</style>
</head>

<body>
<div id="kapsayici" class="bir">
	<div id="alan" class="iki">Javascript Eğitim Seti</div>
</div>
<div id="sonuc"></div>

<script type="text/javascript" language="javascript">
// scrollWidth 		:	Belge içerisindeki herhangi bir HTML elemanının toplam yatay kaydırma genişliği değerini elde etmek için kullanılır.
// scrollHeight 	:	Belge içerisindeki herhangi bir HTML elemanının toplam dik kaydırma yüksekliği değerini elde etmek için kullanılır.
/*
Hesaplama :
Genişlikte			:	padding-left + genişlik + padding-right
Yükseklikte			:	padding-top + yükseklik + padding-bottom
*/

var hesapbir	=	document.getElementById("kapsayici").scrollWidth;
var hesapiki	=	document.getElementById("kapsayici").scrollHeight;
document.getElementById("sonuc").innerHTML = "HTML elemanının toplam kaydırılabilir yatay genişlik değeri : " + hesapbir + "px <br />" + "HTML elemanının toplam kaydırılabilir dikey yükseklik değeri : " + hesapiki + "px";

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>

<div onclick="ornek()">TIKLA</div>
<div id="sonucalani"></div>

<script type="text/javascript" language="javascript">
// onclick 		:	Belge içerisindeki herhangi bir elemana mouse (fare) ile sol tıklandığında belirtilecek olan fonksiyon çalışır.

function ornek(){
	document.getElementById("sonucalani").innerHTML = "TIKLAMA İŞLEMİ GERÇEKLEŞTİ";
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<div>İşlem sonucunu görmek istiyorsanız aşağıdaki işlem metnine çift tıklayınız!</div>
<div ondblclick="deneme()">5 + 3 = <span id="sonucalani"></span></div>

<script type="text/javascript" language="javascript">
// ondblclick 	:	Belge içerisindeki herhangi bir elemana mouse (fare) ile çift sol tıklandığında belirtilecek olan fonksiyon çalışır.

function deneme(){
	var islem = 5 + 3;
	document.getElementById("sonucalani").innerHTML = islem;
}

</script>
</body>
</html>
```
```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<button id="kimlik" onmousedown="ornek()">Tıklayınız</button>

<script type="text/javascript" language="javascript">
// onmousedown 	:	Belge içerisindeki herhangi bir elemana mouse (fare) ile sol veya sağ tıklandığında belirtilecek olan fonksiyon çalışır.

function ornek(){
	document.getElementById("kimlik").innerHTML = "Butona Tıklandı, Lütfen Bekleyiniz...";
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<div oncontextmenu="ornek()" contextmenu="menumuz">Buraya Sağ Tıklayınız</div>

<menu id="menumuz" type="context">
	<menuitem label="YENİLE - EXTRA EĞİTİM" onclick="window.location.reload()"></menuitem>
</menu>

<div id="sonucalani"></div>

<script type="text/javascript" language="javascript">
// oncontextmenu 	:	Belge içerisindeki herhangi bir elemana mouse (fare) ile sağ tıklandığında belirtilecek olan fonksiyon çalışır.

function ornek(){
	document.getElementById("sonucalani").innerHTML = "Sağ tıklama oldu, contextmenu açıldı.";
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<img id="resmim" src="dunya.png" border="0" width="75" height="75" onmouseover="ornek()">

<script type="text/javascript" language="javascript">
// onmouseover 		:	Belge içerisindeki herhangi bir elemanın mouse (fare) ile üzerine gelindiğinde belirtilecek olan fonksiyon çalışır.

function ornek(){
	document.getElementById("resmim").style.width	=	"250px";
	document.getElementById("resmim").style.height	=	"250px";
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<img src="dunya.png" id="resimbir" border="0" width="75" height="75" onmouseover="buyut()" onmouseout="kucult()">

<script type="text/javascript" language="javascript">
// onmouseout 	:	Belge içerisindeki herhangi bir elemanın mouse (fare) ile üzerinden gidildiğinde belirtilecek olan fonksiyon çalışır.

function buyut(){
	document.getElementById("resimbir").style.width 	=	"250px";
	document.getElementById("resimbir").style.height 	=	"250px";
}

function kucult(){
	document.getElementById("resimbir").style.width 	=	"75px";
	document.getElementById("resimbir").style.height 	=	"75px";
}

</script>
</body>
</html>
<!-- //Örnek 2 -->
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<div onmouseover="aktifbir()" onmouseout="pasifbir()">Volkan Alakent Javascript Eğitim Seti</div>
<div onmouseover="aktifiki()" onmouseout="pasifiki()">Volkan Alakent Php Eğitim Seti</div>
<div onmouseover="aktifuc()" onmouseout="pasifuc()">Volkan Alakent Html Eğitim Seti</div>
<div onmouseover="aktifdort()" onmouseout="pasifdort()">Volkan Alakent Css Eğitim Seti</div>
<div onmouseover="aktifbes()" onmouseout="pasifbes()">Volkan Alakent Python Eğitim Seti</div>

<script type="text/javascript" language="javascript">
// onmouseout 	:	Belge içerisindeki herhangi bir elemanın mouse (fare) ile üzerinden gidildiğinde belirtilecek olan fonksiyon çalışır.

function aktifbir(){
	document.getElementsByTagName("DIV")[0].style.backgroundColor = "#F1F1F1";
}
function pasifbir(){
	document.getElementsByTagName("DIV")[0].style.backgroundColor = "white";
}

function aktifiki(){
	document.getElementsByTagName("DIV")[1].style.backgroundColor = "#F1F1F1";
}
function pasifiki(){
	document.getElementsByTagName("DIV")[1].style.backgroundColor = "white";
}

function aktifuc(){
	document.getElementsByTagName("DIV")[2].style.backgroundColor = "#F1F1F1";
}
function pasifuc(){
	document.getElementsByTagName("DIV")[2].style.backgroundColor = "white";
}

function aktifdort(){
	document.getElementsByTagName("DIV")[3].style.backgroundColor = "#F1F1F1";
}
function pasifdort(){
	document.getElementsByTagName("DIV")[3].style.backgroundColor = "white";
}

function aktifbes(){
	document.getElementsByTagName("DIV")[4].style.backgroundColor = "#F1F1F1";
}
function pasifbes(){
	document.getElementsByTagName("DIV")[4].style.backgroundColor = "white";
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<div style="background-color:#F1F1F1; border:1px solid black; margin:10px; padding:10px; width:250px; height:250px;" onmouseenter="ornek()"><span id="sonucalani">Bu Alana Mouse İle Geliniz</span></div>

<script type="text/javascript" language="javascript">
// onmouseenter 	:	Belge içerisindeki herhangi bir elemanın mouse (fare) ile kapsama alanına giriş yapıldığında belirtilecek olan fonksiyon çalışır.

function ornek(){
	document.getElementById("sonucalani").innerHTML = "Alanın Kapsama Alanına Gelindi";
	document.getElementById("sonucalani").style.fontSize = "25px";
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
<style>
.ornek{
	background-color:yellow;
	width:250px;
	height:130px;
	border:1px dotted black;
	padding:10px;
	padding-top:100px;
	text-align:center;
}
.ornekiki{
	background-color:white;
	padding:25px;
}
</style>
</head>

<body>
<div id="kapsamalani" class="ornek" onmouseenter="demobir()" onmouseleave="demoiki()"><span id="sonucalani" class="ornekiki">Javascript</span></div>
<br /><br />
<div id="islemsonucu"></div>
<script type="text/javascript" language="javascript">
// onmouseleave 	:	Belge içerisindeki herhangi bir elemanın mouse (fare) ile kapsama alanından çıkış yapıldığında belirtilecek olan fonksiyon çalışır.

function demobir(){
	document.getElementById("islemsonucu").innerHTML = "Kapsama Alanına Giriş Yapıldı!";
}

function demoiki(){
	document.getElementById("islemsonucu").innerHTML = "Kapsama Alanından Çıkış Yapıldı!";
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<div id="kimlik" style="background-color:#E5E3E3; width:280px; height:130px; border:1px solid black; padding:10px; padding-top:120px; margin:10px; text-align:center;" onmousemove="deneme()">0</div> 


<script type="text/javascript" language="javascript">
// onmousemove 	:	Belge içerisindeki herhangi bir elemanın mouse (fare) ile kapsama alanında gezildiğinde belirtilecek olan fonksiyon çalışır.

var sayi	=	0;

function deneme(){
	document.getElementById("kimlik").innerHTML = sayi+=1;
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<div onmouseup="ornek()">Javascript Eğitim Seti</div>

<script type="text/javascript" language="javascript">
// onmouseup	:	Belge içerisindeki herhangi bir elemana mouse (fare) ile sol basılı duran tıklama bırakıldığında belirtilecek olan fonksiyon çalışır.

function ornek(){
	alert("Tıklama Bırakıldı!");
}
</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<div id="kimlik" onmousewheel="ornek()">Javascript Eğitim Seti - Volkan Alakent</div>
<!-- <div id="kimlik" onwheel="ornek()">Javascript Eğitim Seti - Volkan Alakent</div> -->

<script type="text/javascript" language="javascript">
// onmousewheel		&		onwheel			:	Belge içerisindeki herhangi bir eleman üzerindeyken mouse'un (farenin) tekerleği yukarı veya aşağı yuvarlandığında belirtilecek olan fonksiyon çalışır.

function ornek(){
	document.getElementById("kimlik").style.fontSize	=	"30px";
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<div onmousedown="ornek()">Bu Alan Üzerinde Mouse'un Herhangi Bir Tuşuna Basınız</div>
<div id="sonucalani"></div>

<script type="text/javascript" language="javascript">
// button 	:	Belge içerisinde mouse (fare) ile tıklama event'ı (olayı) gerçekleştiğinde mouse'un (farenin) hangi tuşuna basıldığı değerini geriye döndürür.
/*
0	:	Sol Tuş
1	:	Orta Tuş & Tekerlek
2	:	Sağ Tuş

Internet Explorer (8 ve 8 öncesi sürümleri)
1	:	Sol Tuş
2	:	Sağ Tuş
4	:	Orta Tuş & Tekerlek
*/

function ornek(){
	var tusdegeri	=	event.button;
	if(tusdegeri==0){
		document.getElementById("sonucalani").innerHTML = 	"Mouse'un sol tuşuna basıldı";
	}else if(tusdegeri==1){
		document.getElementById("sonucalani").innerHTML = 	"Mouse'un orta tuşuna & tekerler tuşuna basıldı";
	}else if(tusdegeri==2){
		document.getElementById("sonucalani").innerHTML = 	"Mouse'un sağ tuşuna basıldı";
	}
}

</script>
</body>
</html>
```
```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<div onmousedown="ornek()">Bu Alan Üzerindeyken Mouse'unuzun Herhangi Bir Tuşuna veya Tuşlarına Basınız.</div>
<div id="sonucalani"></div>

<script type="text/javascript" language="javascript">
// buttons		:	Belge içerisindeki mouse (fare) ile tıklama event'ı (olayı) gerçekleştiğinde mouse'un (farenin) hangi tuşuna veya tuşlarına basıldığı değerini geriye döndürür.
/*
1	:	Sol Tuş
2	:	Sağ Tuş
3	:	Sol Tuş ve Aynı Anda Sağ Tuş
4	:	Orta Tuş & Tekerlek
5	:	Sol Tuş ve Aynı Anda Orta Tuş & Tekerlek
6	:	Sağ Tuş ve Aynı Anda Orta Tuş & Tekerlek
8	:	4. Tuş
16	:	5. Tuş
*/

function ornek(){
	var sonuc	=	event.buttons;
	if(sonuc==1){
		document.getElementById("sonucalani").innerHTML		=	"Mouse'un sol tuşuna basıldı";
	}else if(sonuc==2){
		document.getElementById("sonucalani").innerHTML		=	"Mouse'un sağ tuşuna basıldı";
	}else if(sonuc==3){
		document.getElementById("sonucalani").innerHTML		=	"Mouse'un sol tuşuna ve aynı anda sağ tuşuna basıldı";
	}else if(sonuc==4){
		document.getElementById("sonucalani").innerHTML		=	"Mouse'un orta tuşuna & tekerlek tuşuna basıldı";
	}else if(sonuc==5){
		document.getElementById("sonucalani").innerHTML		=	"Mouse'un sol tuşuna ve aynı anda orta tuşuna & tekerlek tuşuna basıldı";
	}else if(sonuc==6){
		document.getElementById("sonucalani").innerHTML		=	"Mouse'un sağ tuşuna ve aynı anda orta tuşuna & tekerlek tuşuna basıldı";
	}else if(sonuc==8){
		document.getElementById("sonucalani").innerHTML		=	"Mouse'un 4. tuşuna basıldı";
	}else if(sonuc==16){
		document.getElementById("sonucalani").innerHTML		=	"Mouse'un 5. tuşuna basıldı";
	}else{
		document.getElementById("sonucalani").innerHTML		=	sonuc;
	}
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<button onclick="ornek()">Tıkla</button>
<div id="sonucalani"></div>

<script type="text/javascript" language="javascript">
// detail		:	Belge içerisindeki mouse (fare) ile tıklama event'ı (olayı) gerçekleştirildiğinde mouse'a (fareye) kaç defa tıklandığı sayısı değerini geriye döndürür.

function ornek(){
	var say		=	event.detail;
	document.getElementById("sonucalani").innerHTML = "Butona Tıklanma Sayısı : " + say;
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
<style>
body{
	margin:0;
	padding:0;
}
.mousealani{
	background-color:#f1F1F1;
	margin:0;
	padding:0;
	width:100%;
	height:500px;
	border:1px solid black;
	text-align:center;	
}
.sonucalani{
	background-color:#f1F1F1;
	margin:0;
	margin-top:5px;
	padding:5px;
	width:100%;
	border:1px solid black;
	text-align:center;	
}
</style>
</head>

<body>
<div class="mousealani" onmousemove="ornek()">Mouse'u (Fareyi) bu alanda gezdiriniz.</div>
<div class="sonucalani">Mouse'un Koordinatı : (X) <span id="xdegeri"></span> (Y) <span id="ydegeri"></span></div>

<script type="text/javascript" language="javascript">
// screenX 	:	Belge içerisindeki herhangi bir mouse (fare) event'ı (olayı) gerçekleştiğinde bilgisayar ekranına göre mouse'un (farenin) yatay konum koordinatının değerini geriye döndürür.
// screenY 	:	Belge içerisindeki herhangi bir mouse (fare) event'ı (olayı) gerçekleştiğinde bilgisayar ekranına göre mouse'un (farenin) dikey konum koordinatının değerini geriye döndürür.

function ornek(){
	var xdegerinibul	=	event.screenX;
	var ydegerinibul	=	event.screenY;
	document.getElementById("xdegeri").innerHTML = xdegerinibul;
	document.getElementById("ydegeri").innerHTML = ydegerinibul;
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body style="margin:0;">
<div onmousemove="ornek()" style="background-color:#F1F1F1; border:1px solid black; margin:0; padding:0; text-align:center; width:100%; height:500px;">Mouse'u (Fareyi) bu alan içerisinde gezdiriniz.</div>
<div style="background-color:#F1F1F1; border:1px solid black; margin:0; margin-top:5px; padding:0; text-align:center; width:100%;">Mouse'un Koordinatı : (X) <span id="xdegeralani"></span> (Y) <span id="ydegeralani"></span></div>

<script type="text/javascript" language="javascript">
// clientX	:	Belge içerisindeki herhangi bir mouse (fare) event'ı (olayı) gerçekleştiğinde browser (tarayıcı) penceresine göre mouse'un (farenin) yatay konum koordinatının değerini geriye döndürür.
// clientY	:	Belge içerisindeki herhangi bir mouse (fare) event'ı (olayı) gerçekleştiğinde browser (tarayıcı) penceresine göre mouse'un (farenin) dikey konum koordinatının değerini geriye döndürür.

function ornek(){
	var xdegerinibul	=	event.clientX;
	var ydegerinibul	=	event.clientY;
	document.getElementById("xdegeralani").innerHTML = xdegerinibul;
	document.getElementById("ydegeralani").innerHTML = ydegerinibul;
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
<style>
body{
	margin:0;
}
.bir{
	background-color:#F1F1F1;
	text-align:center;
	width:100%;
	height:500px;
	border:1px dotted black;
}
</style>
</head>

<body>
<div class="bir" onmousemove="ornek()">Mouse'u (fareyi) bu alan içerisinde gezdiriniz.</div>
<div id="sonucalani"></div>
<script type="text/javascript" language="javascript">
// pageX 	:	Belge içerisindeki herhangi bir mouse (fare) event'ı (olayı) gerçekleştiğinde browser (tarayıcı) penceresine / sayfaya göre mouse'un (farenin) yatay konum koordinatının değerini geriye döndürür.
// pageY 	:	Belge içerisindeki herhangi bir mouse (fare) event'ı (olayı) gerçekleştiğinde browser (tarayıcı) penceresine / sayfaya göre mouse'un (farenin) dikey konum koordinatının değerini geriye döndürür.

function ornek(){
	var xdegerinibul	=	event.pageX;
	var ydegerinibul	=	event.pageY;
	document.getElementById("sonucalani").innerHTML = "Mosu'un Koordinatı : (X) " + xdegerinibul + " (Y) " + ydegerinibul;
}

</script>
</body>
</html>
```
```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<input type="text" onkeydown="ornek()">

<script type="text/javascript" language="javascript">
// onkeydown 	:	Belge içerisindeki herhangi bir eleman üzerinde klavyeden herhangi bir tuşa basıldığında belirtilecek olan fonksiyon çalışır.

function ornek(){
	alert("Klavyeden tuşa basıldı!");
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<textarea id="metinalani" onkeypress="ornek()"></textarea>
<div id="sonuc"></div>
<script type="text/javascript" language="javascript">
// onkeypress	:	Belge içerisindeki herhangi bir eleman üzerinde klavyeden herhangi bir tuşa basıldığında belirtilecek olan fonksiyon çalışır.

function ornek(){
	document.getElementById("sonuc").innerHTML = "Bir tuşa basıldı!";
	document.getElementById("metinalani").style.backgroundColor = "yellow";
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<textarea onkeyup="deneme()"></textarea>
<script type="text/javascript" language="javascript">
// onkeyup	:	Belge içerisindeki herhangi bir eleman üzerinde klavyeden basılı duran bir tuş bırakıldığında belirtilecek olan fonksiyon çalışır.

function deneme(){
	alert("Tuş basılarak bırakıldı");
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<input id="metinalani" type="text" onkeypress="ornek()">
<div id="sonucalani"></div>
<script type="text/javascript" language="javascript">
// key 	:	Belge içerisindeki onkeypress, onkeydown veya onkeyup event'ı (olayı) gerçekleştiğinde klavyeden basılan tuşun değerini geriye döndürür.

function ornek(){
	var basilantus	=	event.key;
	document.getElementById("sonucalani").innerHTML = "Basılan tuş : " + basilantus;
}

</script>
</body>
</html>
```

```Html
<!doctype html>
<html lang="tr-TR">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8">
<title>Extra Eğitim</title>
</head>

<body>
<input type="text" onkeypress="ornek()">
<div id="sonuc"></div>
<script type="text/javascript" language="javascript">
// charCode		:	Belge içerisindeki onkeypress event'ı (olayı) gerçekleştiğinde klavyeden basılan tuşun unicode (evrensel kod) kodlamasına dönüştürerek oluşturduğu değeri geriye döndürür.

function ornek(){
	var deger	=	event.charCode;
	document.getElementById("sonuc").innerHTML += deger + " ";
}

</script>
</body>
</html>
```