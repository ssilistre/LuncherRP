# LuncherRP

Open Source Fivem Luncher Library

Yeni Tanıtım Videosu:  [https://youtu.be/5Ccpd3Cq-No](https://youtu.be/5Ccpd3Cq-No)  Eski Youtube anlatımı için:  [https://www.youtube.com/watch?v=FcHfcvAY8CU](https://www.youtube.com/watch?v=FcHfcvAY8CU)

## [](https://github.com/ssilistre/LuncherRP/tree/19767af405c79e0e2ef41575d2e5f95659aa7d75#sunucu-kay%C4%B1t-i%C3%A7in--httppanelfivemcodecom)Sunucu Kayıt için =  [http://panel.fivemcode.com](http://panel.fivemcode.com/)

[![Resim1](https://camo.githubusercontent.com/221f16205d5128eed52a12bdd39338e8bd69adc8/68747470733a2f2f692e68697a6c69726573696d2e636f6d2f3730393166462e706e67)](https://camo.githubusercontent.com/221f16205d5128eed52a12bdd39338e8bd69adc8/68747470733a2f2f692e68697a6c69726573696d2e636f6d2f3730393166462e706e67)

Selam arkadaşlar ücretsiz açık kaynaklı bir luncher geliştirdim. Bunuda minik bir kütüphane ile bağladım. Minik kütüphaneyide web panele bağladım fivemcode.com ortaya çıktı. İsteyen arkadaşlar ücretsiz bir şekilde istedikleri tasarımı giydirerek üzerinde düzenleme yapabilir.

**Bir takım özellikler;**  
-Steam açık mı değil mi kontrol ediyor.  
-Luncherı kapattığınızda oyunda kapanıyor.  
-Basit sürekli güncellenen hile koruma algoritması mevcut.  
-Luncher içine link ekleyebiliyorsunuz sınırsız.  
-Discord üstünden mesaj gönderebilme -Online sunucudaki üyelerin sayısını görebilme -Lunchersız girişi kapatabilme -Whitelist özelliği ile üyeleri yönetebilme -Web panelden güncelleme yayınlama -Web panelden duyurular yayınlama -Otomatik steam id ve steam adını alır uygulama

**Yeni Standart Tarz**  [![Goruntu](https://camo.githubusercontent.com/a8d43e7b5130a820bfd00d21db2807b7fe3b4460/68747470733a2f2f692e68697a6c69726573696d2e636f6d2f715a346237312e706e67)](https://camo.githubusercontent.com/a8d43e7b5130a820bfd00d21db2807b7fe3b4460/68747470733a2f2f692e68697a6c69726573696d2e636f6d2f715a346237312e706e67)

Projeyi github adresimden indirip üzerinde düzenleme yapabilirsiniz(Bu yol ile çok hızlı ilerleme kaydedebilirsiniz). Birden fazla kişi aynı özelliği isterse ekleyebilirim.  
Eğer projeyi indirip düzenlerseniz aşağıdaki 3 adımı yapmanıza gerek yok.

**1-Adım**  = Yeni bir proje oluşturduktan sonra fivemluncher.dll projeye bileşen olarak eklemelisiniz.  
[![Adim1](https://camo.githubusercontent.com/d990cd0b2b186f8c96bfc69f81c2483d391a84fa/68747470733a2f2f73362e67696679752e636f6d2f696d616765732f6164696d312e676966)](https://camo.githubusercontent.com/d990cd0b2b186f8c96bfc69f81c2483d391a84fa/68747470733a2f2f73362e67696679752e636f6d2f696d616765732f6164696d312e676966)

**Adım 2**  = Aşağıda ki kodu form.cs eklemelisiniz.

Kopyala yapıştır yapmak için :  
**lib rp = new lib();**

**Adım 3**  = Usingler kımına aşağıdaki kodu eklemek:  
using fivemLuncher;

[![adim3](https://camo.githubusercontent.com/795a31bd830f5d417da461f70f4b66a77ff17d90/68747470733a2f2f692e68697a6c69726573696d2e636f6d2f7068506548312e706e67)](https://camo.githubusercontent.com/795a31bd830f5d417da461f70f4b66a77ff17d90/68747470733a2f2f692e68697a6c69726573696d2e636f6d2f7068506548312e706e67)

Evet şimdi ne yapmak istiyorsanız luncherda onla alakalı komutu çağırabilirsiniz tüm komutlar aşağıda açıklamaları ile verilmiştir.

**Kullanabileceğiniz komutlar:**

-   rp.serverinfos("serverkey") //Bu size özel sunucu keyinizle bilgilerinizi çeken komut.
-   rp.kisiSayisi;// (Bu string değerdir online kişi sayısı bilgini barındırır.)
-   rp.sunucuDurum;// (Bu string değer sunucunuzun durumunu barındırır.)
-   rp.DiscordRC("ilk mesaj" , "ikinci mesaj"); //Bu aşağıdaki discord rc görünümün ilk satırı ve ikinci satırıdır.
-   rp.SteamUserName; //(Bu string değer bizim kullanıcı adımızı barındırır.)
-   rp.stopHacks(); //Hile algoritmasını çalıştırır. 1 kere çalıştırır. Sürekli olması için timer içine eklemelisiniz.
-   rp.ConnectWithOutWhitelist("serverkey"); //Bu komut luancher olmadan sunucuya girişi imkansız kılmaktadır.
-   rp.ConnectWithWhitelist("serverkey"); //Bu komut ise luancher kontrolü yapar fakat whitelistede bakar. Whitelist için panel.fivemcode.com bakabilirsiniz.
-   rp.ConnectFivem("ipadres" , "port numarası"); //normal bağlantı komutu
-   rp.Cachedelete(); //Cache dosyalarını temizleyen komut.
-   rp.closeFivem(); //Fivemi kapatır bu komut.
-   rp.open("discord"); //discord açar ts açar artık ne istiyorsanız onu açar bu komut.
-   rp.PlaySound("müzik.mp4"); //müzik mp4 adındaki şarkıyı çalar bu komut.
-   rp.ownUpdate("version url" , "indirilicek dosyanın adresi"); // bu komut verion txt içine bakıp yeni güncelleme indirir.
-   rp.zipDownload("indirilicek zip adresi","zipin adı"); // Bu komut zip dosya indirip onu seçilen yere çıkartır.
-   rp.duyurular; //(Bu komut string olarak duyurular yazısını barındırır.)
-   rp.steamidgirformu(); //(Bu komut steamid girme formunu açtırır)
-   rp.steamid64("buraya steam 64 idsi"); //Bu alana steam 64 idi vererek steamhex idisini alabilirsiniz.

Özel olarak discord sunucumdan bana ulaşabilirsiniz :  [https://discord.gg/tD5AXcA](https://discord.gg/tD5AXcA)

**Discord RC Görünümü:**

[![RC](https://camo.githubusercontent.com/7c4f67992b8524ec5630dd02b6ecde74154e6cbe/68747470733a2f2f692e68697a6c69726573696d2e636f6d2f63696f49324c2e706e67)](https://camo.githubusercontent.com/7c4f67992b8524ec5630dd02b6ecde74154e6cbe/68747470733a2f2f692e68697a6c69726573696d2e636f6d2f63696f49324c2e706e67)

### [](https://github.com/ssilistre/LuncherRP/tree/19767af405c79e0e2ef41575d2e5f95659aa7d75#sunucuyu-buradan-kayit-ettirebilirsiniz-httpspanelfivemcodecom)Sunucuyu buradan kayit ettirebilirsiniz  [https://panel.fivemcode.com](https://panel.fivemcode.com/)

En sonunda sunucu dosyalarını indirin sunucu dosyalarının içinde ki server.lua aşağıdaki resimdeki alanları düzenleyin.Altı kırmızı çizili alana sunucu kayit daki özel idnizi giriniz.  [![Lua görüntüsü](https://camo.githubusercontent.com/235571a8fdca0388588f77c007802647d4357b7a/68747470733a2f2f692e68697a6c69726573696d2e636f6d2f4841524350392e706e67)](https://camo.githubusercontent.com/235571a8fdca0388588f77c007802647d4357b7a/68747470733a2f2f692e68697a6c69726573696d2e636f6d2f4841524350392e706e67)

**Sunucu dosyalari için**  [https://github.com/ssilistre/LuncherRP/releases/download/V1.0.0.8/FiveMCode.com.rar](https://github.com/ssilistre/LuncherRP/releases/download/V1.0.0.8/FiveMCode.com.rar)

Not bir bağlantı sorunu yaşarsanız lua nın içindeki api='' yazan yere 2 veya 3 yazınız.

Sorunlar olabilir bana yazarak iletebilirsiniz. Eklenmesini istediğiniz şeyler olabilir onları da iletebilirsiniz. Ücretsiz arkadaşlar üstüne sizde geliştirme ekleyebilirsiniz.  
Yukarıdaki komutları kullanarak kendi tasarımızı da geliştirmeniz mümkün. Burada ki hile algoritması %100 sonuç vermeyebilir , engelleyecektir. Minik bir denemeyi cheatengine ile yapabilirsiniz.

**Github projesi linki**  :  [https://github.com/ssilistre/LuncherRP](https://github.com/ssilistre/LuncherRP)
