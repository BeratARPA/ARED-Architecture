# ARED Architecture (Action, Rule, Event-Driven Architecture)

ARED Architecture, uygulamalarınızı olay tabanlı, kural tabanlı ve eylem odaklı bir şekilde kişiselleştirmenizi sağlayan yenilikçi bir mimaridir. Kullanıcıların belirli olaylar için özelleştirilmiş eylemler ve kurallar tanımlayarak uygulamanın davranışını dinamik olarak yönetmelerine olanak tanır.

## İçindekiler

- [Özellikler](#özellikler)
- [Mimari](#mimari)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Senaryolar](#senaryolar)
- [Katkıda Bulunma](#katkıda-bulunma)
- [Lisans](#lisans)
- [İletişim](#iletişim)

## Özellikler

- **Dinamik Kural Tanımlama:** Kullanıcılar, uygulamanın belirli olaylara ve koşullara göre nasıl tepki vereceğini tanımlayan kurallar oluşturabilirler.
- **Kullanıcı Eylemleri:** Eylem tabanlı yapı sayesinde, kullanıcılar çeşitli eylemleri (örneğin, veri güncellemeleri, bildirimler, kullanıcı arayüzü değişiklikleri) özelleştirebilirler.
- **Olay Tabanlı Kişiselleştirme:** Kullanıcılar, uygulama içindeki belirli olaylara göre kişiselleştirilmiş davranışları belirleyebilirler.
- **Gerçek Zamanlı Güncellemeler:** Yapılan değişiklikler anında uygulama üzerinde etkili olur ve sonuçlar hemen gözlemlenebilir.

## Mimari

ARED Architecture, üç temel bileşenden oluşur:

1. **Eylemler (Actions):**
   - Uygulamanın belirli olaylar doğrultusunda gerçekleştireceği işlemler.
   - Örnek: Veri güncellemesi, e-posta gönderimi, kullanıcı arayüzü güncellemesi.

2. **Kurallar (Rules):**
   - Belirli koşullar altında hangi eylemlerin gerçekleştirileceğini tanımlayan mantıksal yapılar.
   - Örnek: “Eğer kullanıcı bir ürünü sepete eklerse, sepet toplamını güncelle.”

3. **Olaylar (Events):**
   - Uygulama içinde gerçekleşen belirli durumlar veya tetikleyiciler.
   - Örnek: Kullanıcı giriş yaptı, yeni bir kayıt oluşturuldu, veri güncellendi.

### Akış Şeması

1. **Olay Tetikleyici:** Uygulamada bir olay meydana gelir.
2. **Kural Değerlendirmesi:** Olay meydana geldiğinde, ilgili kurallar değerlendirilir.
3. **Eylem Gerçekleştirme:** Kurallar doğrultusunda gerekli eylemler gerçekleştirilir.
4. **Sonuç:** Eylemler uygulama içinde anında görünür.

## Kullanım

ARED Architecture'ı kullanmak için aşağıdaki adımları izleyin:

### Kural Oluşturma

- **Yeni Bir Kural Tanımlayın:** Kullanıcıların belirli olaylara tepki olarak ne yapacaklarını belirleyen yeni kurallar oluşturun.
  - Örnek: "Eğer kullanıcı bir ürün satın alırsa, kullanıcıya teşekkür e-postası gönder."

- **Kuralı Test Edin:** Oluşturduğunuz kuralları test edin ve olayları tetikleyerek eylemlerin doğru şekilde gerçekleştiğinden emin olun.

### Eylem Tanımlama

- **Eylem Ekleyin:** Uygulamanın gerçekleştireceği eylemleri tanımlayın.
  - Örnek: "Veritabanına veri ekleme", "Kullanıcı arayüzünü güncelleme."

- **Eylemi İlişkilendirin:** Tanımladığınız eylemleri, ilgili kurallar ve olaylarla ilişkilendirin.

### Olay Tetikleyicileri

- **Olay Tanımlayın:** Uygulamanın içindeki olayları tanımlayın.
  - Örnek: "Kullanıcı giriş yaptı", "Yeni bir kayıt oluşturuldu."

- **Olayları Test Edin:** Olayları tetikleyin ve doğru eylemlerin gerçekleştirilip gerçekleştirilmediğini kontrol edin.

## Senaryolar

- **Senaryo 1: Kullanıcı Kaydı**
  - **Olay:** Kullanıcı yeni bir hesap oluşturdu.
  - **Kural:** Yeni kullanıcı kaydı oluşturulduğunda, kullanıcıya hoş geldin e-postası gönder.
  - **Eylem:** Kullanıcı e-posta adresine hoş geldin e-postası gönder.

- **Senaryo 2: Ürün Sepeti**
  - **Olay:** Kullanıcı sepetine bir ürün ekledi.
  - **Kural:** Sepete yeni bir ürün eklendiğinde, sepet toplamını güncelle.
  - **Eylem:** Sepet toplamını güncelle ve kullanıcıya güncel sepet bilgilerini göster.

## Katkıda Bulunma

Bu projeye katkıda bulunmak isterseniz, lütfen aşağıdaki adımları izleyin:

1. **Depoyu Forklayın:** Bu bağlantıyı kullanarak projeyi fork edin.
2. **Yeni Bir Dal Oluşturun:** `git checkout -b yeni-ozellik`
3. **Değişiklikleri Yapın ve Commit Edin:** `git commit -m 'Yeni özellik ekle'`
4. **Dalınızı Gönderin:** `git push origin yeni-ozellik`
5. **Pull Request Açın:** GitHub üzerinden yeni bir pull request açın ve değişikliklerinizi incelemeye sunun.

## Lisans

Bu proje MIT Lisansı altında lisanslanmıştır. Daha fazla bilgi için LICENSE dosyasına bakabilirsiniz.

## İletişim

Herhangi bir sorunuz, geri bildiriminiz veya katkı öneriniz varsa, lütfen [beratarpa@hotmail.com](mailto:beratarpa@hotmail.com) adresinden benimle iletişime geçin.
