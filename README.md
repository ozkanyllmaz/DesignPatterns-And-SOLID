# C# Design Patterns & SOLID Principles

Bu depo, Nesne Yönelimli Programlama (OOP) dünyasının temelini oluşturan **Tasarım Desenleri (Design Patterns)** ve **SOLID Prensiplerinin** C# ile yazılmış temiz, modüler ve anlaşılır örneklerini içermektedir.

Gerçek dünya senaryoları (E-ticaret sistemleri, lojistik operasyonları, ödeme entegrasyonları vb.) kullanılarak, karmaşık mimari yaklaşımlar en sade halleriyle koda dökülmüştür.

## 🚀 Proje Amacı ve Kapsamı

Bu projenin temel amacı; **SOLID prensipleri** ve **Tasarım Desenlerinin (Design Patterns)** yalnızca teorik kavramlar olarak kalmayıp, kodlanmış uygulamalı örnekler üzerinden derinlemesine öğrenilmesidir. Aynı zamanda, modern yazılım geliştirme süreçlerinin vazgeçilmezi olan profesyonel Git ve GitHub kullanım alışkanlıklarının pekiştirilmesi hedeflenmiştir.

Bu doğrultuda proje, aşağıdaki gereksinimler ve standartlar çerçevesinde geliştirilmiştir:

* **Bağımsız Örnekler:** SOLID ve Tasarım Desenleri kapsamında incelenen her bir kavram için, kavramın amacını ve kullanım şeklini net bir şekilde anlatan ayrı senaryolar/sınıflar oluşturulmuştur.
* **Düzenli Klasör Mimarisi:** Tüm projeler ve kodlar; Yaratımsal, Yapısal, Davranışsal desenler ve SOLID prensipleri olmak üzere hiyerarşik ve modüler bir klasör yapısı altında toplanmış, isimlendirmeler anlaşılır tutulmuştur.
* **Versiyon Kontrol Disiplini:** Geliştirme süreci boyunca Git prensiplerine sadık kalınmış; kodlar tek seferde yığınla değil, her bir desenin mantığına uygun, düzenli ve anlamlı commit mesajlarıyla depoya aktarılmıştır.

## 📐 SOLID Prensipleri

Yazılımın sürdürülebilir, okunabilir ve esnek olmasını sağlayan 5 temel prensip de projeye `BadCode` (Kötü Yaklaşım) ve `GoodCode` (Doğru Yaklaşım) klasörlemeleriyle eklenmiştir.

* **[S] Single Responsibility Principle (SRP):** Her sınıfın değişmek için tek bir nedeni olmalıdır. (Kayıt yapan sınıf loglama veya e-posta atma işine karışmaz).
* **[O] Open/Closed Principle (OCP):** Kodlar gelişime açık, değişime kapalı olmalıdır. (Yeni özellikler mevcut kodu değiştirerek değil, yeni sınıflar ekleyerek/arayüzlerle genişletilerek yapılmalıdır - *Bkz: Strategy ve Decorator desenleri*).
* **[L] Liskov Substitution Principle (LSP):** Alt sınıflar, türedikleri üst sınıfların yerine hiçbir kodu bozmadan geçebilmelidir. (Uçamayan bir kuşu uçan kuş sınıfından miras almamak).
* **[I] Interface Segregation Principle (ISP):** İstemciler, kullanmadıkları metotları içeren arayüzleri uygulamaya zorlanmamalıdır. (Şişman arayüzleri daha küçük, spesifik arayüzlere bölmek).
* **[D] Dependency Inversion Principle (DIP):** Üst seviye modüller, alt seviye modüllere doğrudan bağlı olmamalıdır; her ikisi de soyutlamalara (arayüzlere) bağlı olmalıdır. (Bağımlılıkların dışarıdan enjekte edilmesi).

## 📂 İçerik ve Klasör Yapısı

Design Pattern Projeleri 3 temel kategoriye ayrılmıştır:

### 1. Yaratımsal (Creational) Desenler
Nesnelerin nasıl ve nerede üretileceğiyle ilgilenir. `new` anahtar kelimesinin yarattığı bağımlılıkları en aza indirir.
* **Singleton:** Tüm sistemde tek bir örneğin (instance) dolaşmasını sağlar (Thread-safe yapıda).
* **Factory Method:** Üretim işini alt sınıflara devrederek (Patron-Müdür mantığı) nesne yaratımını soyutlar.
* **Abstract Factory:** Birbiriyle ilişkili/uyumlu "ürün aileleri" (örn: Modern ve Viktorya mobilya takımları) üretmek için konsept müdürleri kurar.

### 2. Yapısal (Structural) Desenler
Sınıfların ve nesnelerin yapılarını bozmadan, onları birleştirerek daha büyük ve esnek yapılar kurmayı sağlar.
* **Adapter:** Uyumsuz arayüzleri (Örn: Eski bir banka XML servisi ile modern sistem) birbirine bağlar.
* **Facade:** Karmaşık alt sistemleri (Stok, Ödeme, Fatura, Bildirim) gizleyerek, istemciye (Client) tek ve temiz bir metot sunar.
* **Decorator:** Ana kodu hiç ellemeden, sınıfın etrafını sararak (Matruşka mantığı) dinamik yeni özellikler (Loglama, Caching) ekler.

### 3. Davranışsal (Behavioral) Desenler
Nesneler arası iletişim, algoritma yönetimi ve sorumluluk dağıtımıyla ilgilenir.
* **Strategy:** Farklı algoritmaları (Örn: Farklı ödeme yöntemleri) ayrı sınıflara bölerek çalışma zamanında (runtime) dinamik olarak değiştirilmelerini sağlar.
* **Observer:** Bir nesnenin durumunda değişiklik olduğunda, ona abone olan (Subscribe) diğer servislere otomatik bildirim gönderir.
* **Command:** İstekleri birer nesne (Adisyon) haline getirerek sıraya koymayı, geri almayı (Undo) veya Invoker/MediatR benzeri yapılarla işlemeyi sağlar.

## 🛠️ Teknolojiler ve Kurulum

* **Dil:** C#
* **Platform:** .NET (Console Applications)
* **Geliştirme Ortamı:** Visual Studio 

Projeyi klonlamak için:
```bash
git clone https://github.com/ozkanyllmaz/DesignPatterns-And-SOLID.git