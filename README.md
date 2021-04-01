# LuncherRP
Open Source Fivem Luncher Library
 
Yeni Tanıtım Videosu: 
https://www.youtube.com/watch?v=xSYMGZG4HPg

Eski Youtube anlatımı için: 
https://youtu.be/5Ccpd3Cq-No

![Resim1](https://i.hizliresim.com/7091fF.png)

## Kullanmak için indirdiğiniz dosyanın içindeki Ready klasöründeki Luancherı düzenleyebilirsiniz.
## İndirdiğiniz dosyanın içinde Lua klasörünü sunucunuzda modların kurulu olduğu yere atıp start veriniz.
## OpenSourceDLL bence ellemeyin :d açık kaynak olarak dll paylaşılmıştır.
 
Selam arkadaşlar ücretsiz açık kaynaklı bir luncher geliştirdim. Bunuda minik bir kütüphane ile bağladım.  Minik kütüphaneyide web panele bağladım fivemcode.com ortaya çıktı.
İsteyen arkadaşlar ücretsiz bir şekilde istedikleri tasarımı giydirerek üzerinde düzenleme yapabilir.  
  
**Bir takım özellikler;**  
-Steam açık mı değil mi kontrol ediyor.  
-Luncherı kapattığınızda oyunda kapanıyor.  
-Basit sürekli güncellenen hile koruma algoritması mevcut.  
-Luncher içine link ekleyebiliyorsunuz sınırsız.  
-Discord üstünden mesaj gönderebilme
-Online sunucudaki üyelerin sayısını görebilme
-Lunchersız girişi kapatabilme
-Üyelere Bypass verebilme
-Web panelden güncelleme yayınlama
-Web panelden duyurular yayınlama
-Otomatik steam id ve steam adını alır uygulama

![Resim2](https://i.hizliresim.com/GbemuK.png)

  
Projeyi github adresimden indirip üzerinde düzenleme yapabilirsiniz(Bu yol ile çok hızlı ilerleme kaydedebilirsiniz). Birden fazla kişi aynı özelliği isterse ekleyebilirim.  
Eğer projeyi indirip düzenlerseniz aşağıdaki 3 adımı yapmanıza gerek yok.  
  
**1-Adım** = Yeni bir proje oluşturduktan sonra luancher.dll projeye bileşen olarak eklemelisiniz.  
   ![Adim1](https://s6.gifyu.com/images/adim1.gif)
  
**Adım 2** = Aşağıda ki kodu form.cs eklemelisiniz.  
  
Kopyala yapıştır yapmak için :  
**lib rp = new lib();**  
  
**Adım 3** = Usingler kımına aşağıdaki kodu eklemek:  
using fivemLuncher;  

![adim3](https://i.hizliresim.com/phPeH1.png)

  
  
Evet şimdi ne yapmak istiyorsanız luncherda onla alakalı komutu çağırabilirsiniz tüm komutlar aşağıda açıklamaları ile verilmiştir.  
  
**Kullanabileceğiniz komutlar:**  

 - rp.serverinfos("serverkey") //Bu size özel sunucu keyinizle bilgilerinizi çeken komut.
 - rp.DiscordRC("ilk mesaj" , "ikinci mesaj"); //Bu aşağıdaki discord rc görünümün ilk satırı ve ikinci satırıdır.
 - rp.anticheat(); //Hile algoritmasını çalıştırır. Cpu kullanmaması için background worker içine koymanız yeterlidir.
 - rp.ConnectWithPanel("serverkey"); //Bu komut ise luancher kontrolü yapar 
 - rp.ConnectFivem("ipadres" , "port numarası"); //normal bağlantı komutu
 - rp.discordopen()  //discordu açar ve panelden değiştirebilmenize yarar.
 - rp.ts3open("ipadresi","port") //ts3 açar ve panelden değiştirebilmenize yarar.
 - rp.closeFivem();  //Fivemi kapatır bu komut.
 - rp.open("discord"); //discord açar ts açar artık ne istiyorsanız onu açar bu komut.
 - rp.PlaySound("müzik.mp4"); //müzik mp4 adındaki şarkıyı çalar bu komut.
 - rp.guncelle(); // güncelleme komutudur.
 - rp.duyurular; //(Bu komut string olarak duyurular yazısını barındırır.)
 - rp.steamid64("buraya steam 64 idsi"); //Bu alana steam 64 idi vererek steamhex idisini alabilirsiniz.
 - rp.steamusername(); // bu komut size adamın steamnameni verir.
 - rp.steamhexid(); // bu komut size adamın hexini gösterir.

Hata Mesajlarını değiştirmek için yazılması gerekenler:

            Lang.steamhata = "Lütfen Önce Steam Uygulamasını Başlatın"; //Please firt of open steam.
            Lang.hatalimesajbaslik = "Dikkat dikkat !"; //Error Header Message
            Lang.muzikhata = "Müzik Dosyası Bulunamadı"; //Play Music Not Found Error.
            Lang.panelhata = "Panel Sistemi ile iletişime geçilemedi !"; //Panel System ERROR
            Lang.steam64idgirinhatasi = "Lütfen Sadece Steam64 idsini giriniz."; // Steamid errorr
            Lang.cokfazlaistekhatasi = "Çok fazla istek gönderildi."; //To Much Post Request error.
            Lang.uygulamaacmahatasi = "Açmaya çalıştığınız şeyi bulamadık."; //Open Command error
            Lang.internethatasi = "İnternet bağlantınız bulunamadı."; //Internet Connection Errror.

 

 Özel olarak discord sunucumdan bana ulaşabilirsiniz : https://discord.gg/tD5AXcA

**Discord RC Görünümü:**
  
![RC](https://i.hizliresim.com/cioI2L.png)


### panel.fivemcode.com adresinden engellenen hileleri görebilirsiniz.

### Sunucuyu buradan kayit ettirebilirsiniz https://panel.fivemcode.com
 
 En sonunda sunucu dosyalarını indirin sunucu dosyalarının içinde ki server.lua aşağıdaki resimdeki alanları düzenleyin.Altı kırmızı çizili alana sunucu kayit daki özel idnizi giriniz.
 ![Lua görüntüsü](https://i.hizliresim.com/HARCP9.png)
 
Sorunlar olabilir bana yazarak iletebilirsiniz. Eklenmesini istediğiniz şeyler olabilir onları da iletebilirsiniz. Ücretsiz arkadaşlar üstüne sizde geliştirme ekleyebilirsiniz.  
Yukarıdaki komutları kullanarak kendi tasarımızı da geliştirmeniz mümkün. Burada ki hile algoritması %100 sonuç vermeyebilir , engelleyecektir. Minik bir denemeyi cheatengine ile yapabilirsiniz.  
  
**Github projesi linki** : [https://github.com/ssilistre/LuncherRP](https://github.com/ssilistre/LuncherRP)
