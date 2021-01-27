using System;
using GameHomework.Entity;
using GameHomework.IManager;
using GameHomework.Manager;
using GameHomework.Reposity;
using System.Linq;
namespace GameHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Depoda kayıtlı olan kullanıcıları ekle:");
            UserReposity userReposity = new UserReposity();
            GameReposity gameReposity = new GameReposity();
            CampaignsReposity campaignsReposity = new CampaignsReposity();
            UserManager userManager = new UserManager();
            userManager.Add(userReposity._user);
            userManager.Add(userReposity._user1);
            userManager.Add(userReposity._user2);
            Console.WriteLine("Depoda kayıtlı olan oyunları ekle:");
            GameManager gameManager = new GameManager();
            gameManager.GetProduct(gameReposity._game);
            gameManager.GetProduct(gameReposity._game1);
            gameManager.GetProduct(gameReposity._game2);
            Campaign campaign = new Campaign();
            CampaignManager campaignManager = new CampaignManager();
            EDevletReposity eDevletReposity = new EDevletReposity();
            EDevletManager eDevletManager = new EDevletManager();
            Console.WriteLine("___-___");
            while (true)
            {
                Console.WriteLine("Kullanıcı(Oyuncu) eklemek için 1");
                Console.WriteLine("Kullanıcı(Oyuncu) silmek için 1.1");
                Console.WriteLine("Kullanıcı(Oyuncu) listelemek için 1.2");
                Console.WriteLine("Oyun eklemek için 2");
                Console.WriteLine("İndirim düzenlemek için 3");
                Console.WriteLine("Kullanıcının Edevlet kontrolü için 4");
                Console.WriteLine("Oyun(Ürün sat) 5");
                Console.WriteLine("Standart Kampanya(oluştur) 6");
                Console.WriteLine("Standart Kampanya(uygula) 7");
                Console.WriteLine("Öğrenci Kampanya(oluştur) 8");
                Console.WriteLine("Öğrenci Kampanya(yap) 9");
                Console.WriteLine("E devlet kontrolü 9");
                Console.WriteLine("Konsolu temizlemek için *");
                string choice = Console.ReadLine();
                //Console.Clear();

                if (choice == "1")
                {

                    int PlayerCount = userManager.ToList().Count;
                    Console.WriteLine("Eklemek istediğiniz kullanıcı bilgilerini giriniz");
                    Console.WriteLine("Tc no:");
                    string TcNo = Console.ReadLine();
                    Console.WriteLine("Ad:");
                    string PlayerName = Console.ReadLine();
                    Console.WriteLine("Soyad:");
                    string PlayerSurname = Console.ReadLine();
                    Console.WriteLine("Doğum Yılı:");
                    string BirthYear = Console.ReadLine();
                    Console.WriteLine("Şifreniz:");
                    string PlayerPassword = Console.ReadLine();
                    PlayerCount++;
                    userManager.Add(new User() { Id = PlayerCount, TCKN = TcNo, Name = PlayerName, SurName = PlayerSurname, DateOfbirth = BirthYear, Password = PlayerPassword });

                }
                else if (choice == "1.1")
                {
                    Console.WriteLine("Silmek istediğiniz oyuncunun Tc Numarasını giriniz:");
                    var GelenTCKN = Console.ReadLine();
                    userManager.Delete(userManager.ToList().First(t => t.TCKN == GelenTCKN.ToString()));
                }
                else if (choice == "1.2")
                {
                    Console.WriteLine("Listelenen oyuncular(kullanıcılar)");
                    var users = userManager.ToList();
                    foreach (var user in users)
                    {
                        Console.WriteLine("Id:{0}", user.Id);
                        Console.WriteLine("Tc no:{0}", user.TCKN);
                        Console.WriteLine("Ad:{0}", user.Name);
                        Console.WriteLine("Soyad:{0}", user.SurName);
                        Console.WriteLine("Doğum Yılı:{0}", user.DateOfbirth);
                        Console.WriteLine("Şifreniz:{0}", user.Password);
                        Console.WriteLine("Part of {0} ___", user.Id);
                    }
                }
                else if (choice == "2")
                {

                }
                else if (choice == "5")
                {
                    Console.WriteLine("Satmak istediğiniz ürünün id sini giriniz:");
                    gameManager.SellProduct(userReposity._user, gameReposity._game);
                }
                else if (choice == "6")
                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı bilgilerini giriniz");
                    Console.WriteLine("İndirim için seçili oyun id:");
                    int SelectGame = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("İndirim yüzdesi:");
                    int Percent = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Gecerlilik(true/false):");
                    bool UpDown = Convert.ToBoolean(Console.ReadLine());
                    campaignManager.SaleInf(new Campaign { SelectGame = gameReposity._game, Percent = Percent, UpDown = UpDown });
                }
                else if (choice == "7")
                {
                    campaignManager.SaleCal(campaignsReposity.campaign);
                }
                else if (choice == "8")
                {

                }
                else if (choice == "9")
                {
                    eDevletManager.Control(userReposity._user, eDevletReposity._eDevlet);
                }
                else if (choice == "10")
                {

                }
                else if (choice == "*")
                {
                    Console.Clear();
                }
            }
            Console.Read();
        }
    }
}
