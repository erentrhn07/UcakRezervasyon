# UcakRezervasyon

Bu uygulama, C# dilinde yazılmış, kullanıcıların uçak rezervasyonları oluşturmasına ve kaydedilmiş rezervasyonları görüntülemesine olanak tanıyan bir konsol uygulamasıdır.

1)Lokasyon.cs
Lokasyon sınıfı, bir uçuşun ülke, şehir ve havaalanı bilgilerini içerir.
LokasyonOlusturma sınıfı, Lokasyon sınıfını genişleterek lokasyon bilgilerini dosyadan okuma işlevselliği ekler.

2)Musteri.cs
Musteri sınıfı, bir müşterinin kişisel bilgilerini (ad, soyad, yaş, kimlik numarası, telefon numarası, cinsiyet, engelli durumu) içerir.
MusteriOlusturma Sınıfı (MusteriOlusturma.cs)
MusteriOlusturma sınıfı, kullanıcıdan müşteri bilgilerini almak için gerekli metotları içerir.
Program (Program.cs)
Kullanıcıya rezervasyon oluşturma, kaydedilen rezervasyonları görüntüleme veya çıkış yapma seçenekleri sunan ana program akışını içerir.
MusteriOlusturma ve UcusOlusturma sınıflarını kullanarak rezervasyon oluşturma işlevselliğini sağlar.

3)Rezervasyon.cs
Rezervasyon sınıfı, müşteri ve uçuş bilgilerini alarak bir rezervasyon oluşturmayı sağlar.
RezervasyonGoruntule Sınıfı (RezervasyonGoruntule.cs)
RezervasyonGoruntule sınıfı, kaydedilmiş rezervasyonları görüntülemek için gerekli metotları içerir.

4)Ucak.cs
Ucak sınıfı, bir uçağın model, seri numara ve yolcu kapasitesi bilgilerini içerir.
UcakOlusturma Sınıfı (UcakOlusturma.cs)
UcakOlusturma sınıfı, Ucak sınıfını genişleterek uçak bilgilerini dosyadan okuma işlevselliği ekler.
UcusOlusturma Sınıfı (UcusOlusturma.cs)
UcusOlusturma sınıfı, bir müşteri ve bir uçak kullanarak bir uçuş oluşturmayı sağlar. Müşteriden lokasyon ve tarih bilgisi alır.

5)Dosya İşlemleri
lokasyonlar.txt: Uygulama tarafından kullanılan lokasyon bilgilerini içeren dosya.
ucaklar.txt: Uygulama tarafından kullanılan uçak bilgilerini içeren dosya.
rezervasyonlar.csv: Oluşturulan rezervasyonların kaydedildiği CSV dosyası.

6)Uygulama Kullanımı
Program çalıştırıldığında kullanıcıya rezervasyon oluşturma, kaydedilen rezervasyonları görüntüleme veya çıkış yapma seçenekleri sunulur.
Rezervasyon oluştur seçeneği seçildiğinde, kullanıcıdan müşteri bilgileri alınır.
Uçuş oluşturma aşamasında, aktif uçuşlar listelenir ve kullanıcı lokasyon ve tarih bilgisi girer.
Rezervasyon oluşturulur ve rezervasyonlar.csv dosyasına kaydedilir.
Kaydedilen rezervasyonlar görüntüleme seçeneği seçildiğinde, müşterinin kimlik numarası girilir ve ilgili rezervasyonlar listelenir.
Uygulama, dosya okuma/yazma, hata kontrolü ve kullanıcı girişi işlemlerini içerir.
