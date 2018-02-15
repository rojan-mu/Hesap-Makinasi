# Hesap-Makinasi
Yazilim Muh. Uygulama -1-
Kodları Çalıştırma
Kodları iki farklı şekilde çalıştırabilirsiniz.

Tüm dosyaları sıkıştırılmış olarak indirme
Bu bağlantıya tıklayarak tüm güncel kodları bilgisayarınıza sıkıştırılmış dosya olarak indirebilirsiniz.

Git kod versiyonlama yazılımını kullanarak güncel kodları siteden alma
İlk defa kodları alırken komut satırında aşağıdaki kod çalıştırılabilir. Bu işlem güncel kodları Hesap-Makinasi klasörü içine kopyalar/indirir.

git clone https://github.com/rojan-mu/Hesap-Makinasi.git
Yapılan değişiklikleri siteden almak için:

Yerelde kodlarda değişiklik yapılmamışsa Hesap-Makinasi klasöründe aşağıdaki kod çalıştırılabilir.
git pull origin master
Yerelde değişiklik olduğunu anlamak için aşağıdaki komut sonucunda kırmızı renkli değerlere bakılır. Varsa yerelde değişiklik yapılmıştır.
git status
Yerelde değişiklik olması durumunda aşağıdaki işlemler yapılabiir
Tüm kodları yeniden klonlama
Yerel değişiklikleri geri alıp siteden verileri çekme(Uyarı: yapmış olduğunuz tüm değişiklerin kaybolmasına neden olacaktır!!!)
git reset --hard
git pull origin master
Yerel değişiklikleri onaylayıp(commit) güncel verileri çekme(Bu yöntemde github üzerindeki kodlar ile yereldeki kodlar üzerinde çakışma(conflict) olması durumunda yerel ve uzak kodları birleştirme(merge) gerekecektir. Daha detaylı bilgi için bkz: 1, 2 ve 3):
git add -A
git commit -m "Commit mesajı"
git pull origin master
