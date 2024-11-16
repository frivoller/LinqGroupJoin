# Öğrenci ve Sınıf Veritabanı (Student and Class Database)

Bu proje, C# kullanarak bir **Öğrenci ve Sınıf** veritabanı ilişkilendirmesini simüle eder. LINQ kullanarak, sınıflar ve öğrenciler arasında bir **Group Join** işlemi gerçekleştirilir ve her sınıfa ait öğrenciler listelenir.

---

## Özellikler (Features)

- **Öğrenci Sınıfı (Student Class):** Öğrencinin kimlik, isim ve sınıf bilgilerini tutar.
- **Sınıf Sınıfı (Class Class):** Sınıfın kimlik ve isim bilgilerini tutar.
- **LINQ Sorgusu (LINQ Query):** Öğrencileri sınıflarına göre gruplar ve ekrana çıktı verir.

---

## Kullanım (Usage)

1. **Gerekli Bağımlılıklar (Requirements):**
   - .NET SDK 6.0 veya daha üstü
   - Visual Studio veya .NET CLI

2. **Kodun Çalıştırılması (Run the Code):**
   - `Program.cs` dosyasını bir C# projesine ekleyin.
   - Terminalden çalıştırmak için aşağıdaki adımları izleyin:
     ```bash
     dotnet run
     ```

3. **Çıktı (Output):**
   Kod çalıştırıldığında her sınıfın adı ve o sınıfa ait öğrencilerin listesi ekranda görüntülenir. Eğer bir sınıfta öğrenci yoksa, "Bu sınıfta öğrenci yok." mesajı gösterilir.

---

## Örnek Veri (Sample Data)

### Öğrenciler (Students)
| Öğrenci ID (Student ID) | Adı (Name) | Sınıf ID (Class ID) |
|--------------------------|------------|----------------------|
| 1                        | Ali        | 1                    |
| 2                        | Ayşe       | 1                    |
| 3                        | Mehmet     | 2                    |
| 4                        | Fatma      | 3                    |

### Sınıflar (Classes)
| Sınıf ID (Class ID) | Sınıf Adı (Class Name) |
|---------------------|------------------------|
| 1                   | Matematik (Math)      |
| 2                   | Fizik (Physics)       |
| 3                   | Kimya (Chemistry)     |

---

