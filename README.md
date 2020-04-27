

# LuncherRP
Open Source Fivem Luncher Library


Yeni Tanıtım Videosu: https://youtu.be/5Ccpd3Cq-No
Eski Youtube anlatımı için: https://www.youtube.com/watch?v=FcHfcvAY8CU

## Sunucu Kayıt için = http://panel.fivemcode.com
![Resim1](https://i.hizliresim.com/ovkqDs.png)

  
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
-Whitelist özelliği ile üyeleri yönetebilme
-Web panelden güncelleme yayınlama
-Web panelden duyurular yayınlama
-Otomatik steam id ve steam adını alır uygulama

**Yeni Standart Tarz**


![Goruntu](https://i.hizliresim.com/qZ4b71.png)
  
  
Projeyi github adresimden indirip üzerinde düzenleme yapabilirsiniz(Bu yol ile çok hızlı ilerleme kaydedebilirsiniz). Birden fazla kişi aynı özelliği isterse ekleyebilirim.  
Eğer projeyi indirip düzenlerseniz aşağıdaki 3 adımı yapmanıza gerek yok.  
  
**1-Adım** = Yeni bir proje oluşturduktan sonra fivemluncher.dll projeye bileşen olarak eklemelisiniz.  
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
 - rp.kisiSayisi;// (Bu string değerdir online kişi sayısı bilgini barındırır.)
 - rp.sunucuDurum;// (Bu string değer sunucunuzun durumunu barındırır.)
 - rp.DiscordRC("ilk mesaj" , "ikinci mesaj"); //Bu aşağıdaki discord rc görünümün ilk satırı ve ikinci satırıdır.
 - rp.SteamUserName; //(Bu string değer bizim kullanıcı adımızı barındırır.)
 - rp.stopHacks(); //Hile algoritmasını çalıştırır. 1 kere çalıştırır. Sürekli olması için timer içine eklemelisiniz.
 - rp.ConnectWithOutWhitelist("serverkey"); //Bu komut luancher olmadan sunucuya girişi imkansız kılmaktadır.
 - rp.ConnectWithWhitelist("serverkey"); //Bu komut ise luancher kontrolü yapar fakat whitelistede bakar. Whitelist için panel.fivemcode.com bakabilirsiniz.
 - rp.ConnectFivem("ipadres" , "port numarası"); //normal bağlantı komutu
 - rp.Cachedelete(); //Cache dosyalarını temizleyen komut.
 - rp.closeFivem();  //Fivemi kapatır bu komut.
 - rp.open("discord"); //discord açar ts açar artık ne istiyorsanız onu açar bu komut.
 - rp.PlaySound("müzik.mp4"); //müzik mp4 adındaki şarkıyı çalar bu komut.
 - rp.ownUpdate("version url" , "indirilicek dosyanın adresi"); // bu komut verion txt içine bakıp yeni güncelleme indirir.
 - rp.zipDownload("indirilicek zip adresi","zipin adı"); // Bu komut zip dosya indirip onu seçilen yere çıkartır.
 - rp.duyurular; //(Bu komut string olarak duyurular yazısını barındırır.)
 - rp.steamidgirformu(); //(Bu komut steamid girme formunu açtırır)
 - rp.steamid64("buraya steam 64 idsi"); //Bu alana steam 64 idi vererek steamhex idisini alabilirsiniz.
 

 Özel olarak discord sunucumdan bana ulaşabilirsiniz : https://discord.gg/tD5AXcA

**Discord RC Görünümü:**
  
![RC](https://i.hizliresim.com/cioI2L.png)




### Sunucuyu buradan kayit ettirebilirsiniz https://panel.fivemcode.com
 
 En sonunda sunucu dosyalarını indirin sunucu dosyalarının içinde ki server.lua aşağıdaki resimdeki alanları düzenleyin.Altı kırmızı çizili alana sunucu kayit daki özel idnizi giriniz.
 ![Lua görüntüsü](https://i.hizliresim.com/HARCP9.png)
 
 **Sunucu dosyalari için** https://github.com/ssilistre/LuncherRP/releases/download/V1.0.0.7/yeni_Sunucu_Dosyalari.rar


**Sunucu Durum Görüntüsü**


![Durum](https://i.hizliresim.com/g9mQdf.png)


Sorunlar olabilir bana yazarak iletebilirsiniz. Eklenmesini istediğiniz şeyler olabilir onları da iletebilirsiniz. Ücretsiz arkadaşlar üstüne sizde geliştirme ekleyebilirsiniz.  
Yukarıdaki komutları kullanarak kendi tasarımızı da geliştirmeniz mümkün. Burada ki hile algoritması %100 sonuç vermeyebilir , engelleyecektir. Minik bir denemeyi cheatengine ile yapabilirsiniz.  
  
**Github projesi linki** : [https://github.com/ssilistre/LuncherRP](https://github.com/ssilistre/LuncherRP)
