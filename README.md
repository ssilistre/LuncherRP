# LuncherRP
Open Source Fivem Luncher Library

Video https://www.youtube.com/watch?v=FcHfcvAY8CU

https://www.fivemtr.net/misc.php?page=anahtar




  
![Resim1](https://i.hizliresim.com/KT3m45.png)

  
  
Selam arkadaşlar ücretsiz açık kaynaklı bir luncher geliştirdim. Bunuda minik bir kütüphane ile bağladım.  
İsteyen arkadaşlar ücretsiz bir şekilde istedikleri tasarımı giydirerek üzerinde düzenleme yapabilir.  
  
**Bir takım özellikler;**  
-Steam açık mı değil mi kontrol ediyor.  
-Luncherı kapattığınızda oyunda kapanıyor.  
-Basit sürekli güncellenen hile koruma algoritması mevcut.  
-Luncher içine link ekleyebiliyorsunuz sınırsız.  
-Discord üstünden mesaj gönderebilme
-Online sunucudaki üyelerin sayısını görebilme
-Lunchersız girişi kapatabilme
  

  
  
Projeyi github adresimden indirip üzerinde düzenleme yapabilirsiniz(Bu yol ile çok hızlı ilerleme kaydedebilirsiniz). Birden fazla kişi aynı özelliği isterse ekleyebilirim.  
Eğer projeyi indirip düzenlerseniz aşağıdaki 3 adımı yapmanıza gerek yok.  
  
**1-Adım** = Yeni bir proje oluşturduktan sonra fivemluncher.dll projeye bileşen olarak eklemelisiniz.  
   ![Adim1](https://s6.gifyu.com/images/adim1.gif)
  
**Adım 2** = Aşağıda ki kodu form.cs eklemelisiniz.  
![adim2](https://i.hizliresim.com/4S6xOh.png)

  
Kopyala yapıştır yapmak için :  
ayarlar LuncherRp = new ayarlar();  
  
**Adım 3** = Usingler kımına aşağıdaki kodu eklemek:  
using fivemLuncher;  

![adim3](https://i.hizliresim.com/phPeH1.png)

  
  
Evet şimdi ne yapmak istiyorsanız luncherda onla alakalı komutu çağırabilirsiniz tüm komutlar aşağıda açıklamaları ile verilmiştir.  
  
**Kullanabileceğiniz komutlar:**  

 -   **LuncherRP.servisKontrol();** //olmazsa olmazınız bu hile algoritmasını sürüm bilgisini güncellemek için kullanılıyor. Mutlaka bir yerlere yazmalısınız yoksa hile algoritması çalışmayacaktır.
 -   **LuncherRP.sunucuyabaglan("İp Numarasi", "PortNo");** //adından anlaşıldığı üzere sunucu ip adresinizi ve portunuzu buraya yazıyorsunuz. Tetiklendiğinde sunucuya bağlanıyor.
 -   **LuncherRP.hileDurdur();**//olmazsa olmazlarınızdan hile kontrolü yapıyor. 1 kere yapar bunu o yüzden timer atayabilirsiniz.
 -   **LuncherRP.linkac("[Google](https://www.google.com/)");** //tetiklendiğinde herhangi bir link açar. Ben bunu discord için kullanıyorum.
 -   **LuncherRP.guncellemekontrolet();** //bu kitaplığın güncel mi değil mi olduğunu size söyleyen kod parçası.
 -   **LuncherRP.kapatProgrami();** // Bu komut tetiklendiğinde fivem kapatıyor. Daha fazla önlem almak isterseniz size kalmış oluyor.
 - **LuncherRp.discordMesajYaz("webhooklinki","mesajınız");** //Bu kod ile bir web hook oluşturduktan sonra webhhooklinki daha sonra mesajınızı yazıp göndertebiliyorsunuz.
 - **LuncherRP.steamidgir();** //buda steamid girilmesi gerek yer. Sunucuya özel yapıcaksanız luncherı buna ihtiyacınız olucak.
 - **LuncherRP.onlinekackisi("sunucu ozel no");** //burada sunucuya bağlanıp sunuda kayitli olan kullanicilara bakar test aşamasında. Sunucu özel no yu kendiniz belirtmelisiniz.
 - **  LuncherRP.luncherozelgiris("Özel sunucu no");** //lunchersız sunucuya giriş yapılmasını istemiyorsanız bunu kullanıyorsunuz. Fakat bu test aşamasında özel sunucu no  onlineoyuncusayisında kullandığınız özel numarayla aynı olmalı mesala "112" yazdınız. Her özel sunucu noyu isteyen yere 112 yazmalısınız.
 - **LuncherRP.VeriOku("KategoriAdı", "AnahtarAdı");** //ayarlar.ini  dosyasındaki gibi [Luncher]
Baslik=Luncher adı - Burada kategori adı Luncher anahtar adı ise Baslik bu komut dosyadaki veriyi okumaya yarıyor.
 
 Özel olarak discord sunucumdan bana ulaşabilirsiniz : https://discord.gg/FX9jRCW
 Lunchersız giriş sistemi için plugine ihtiyacınız var onuda https://github.com/ssilistre/LuncherRP/releases/download/V1.0.02/serverdosyalari.rar buradan indirebilirsiniz.
 
 Sunucuyu buradan kayit ettirebilirsiniz https://www.fivemtr.net/misc.php?page=anahtar

Sorunlar olabilir bana yazarak iletebilirsiniz. Eklenmesini istediğiniz şeyler olabilir onları da iletebilirsiniz. Ücretsiz arkadaşlar üstüne sizde geliştirme ekleyebilirsiniz.  
Yukarıdaki komutları kullanarak kendi tasarımızı da geliştirmeniz mümkün. Burada ki hile algoritması %100 sonuç vermeyebilir , engelleyecektir. Minik bir denemeyi cheatengine ile yapabilirsiniz.  
  
**Github projesi linki** : [https://github.com/ssilistre/LuncherRP](https://github.com/ssilistre/LuncherRP)
