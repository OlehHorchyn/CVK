using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1_CVK.Model
{
    public class Department
    {
        public string Id { set; get; }
        public int TotalRecievedBul { set; get; }
        public int NumberOfVotersIncluded { set; get; }
        public int NumberOfVotersIncludedPlace { set; get; }
        public int NumberOfUnusedBul { set; get; }
        public int NumberOfVotersRecievedIndoors { set; get; }
        public int NumberOfVotersRecievedAtPlace { set; get; }
        public int TotalNumberVoters { set; get; }
        public int NumberOfBulNotConsider { set; get; }
        public int TotalNumberVotersVoting { set; get; }
        public int NumberOfBulInvalid { set; get; }
        public int BalshowGenadiy { set; get; }
        public int BezsmertniyRoman { set; get; }
        public int BogomoletzOlga { set; get; }
        public int BogoslovskaInna { set; get; }
        public int BoykoYrii { set; get; }
        public int BondarViktor { set; get; }
        public int VaschenkoOleksandr { set; get; }
        public int VilkulOleksandr { set; get; }
        public int GaberMykola { set; get; }
        public int GrytsenkoAnatoliy { set; get; }
        public int DanulyukOleksandr { set; get; }
        public int DerevyankoYrii { set; get; }
        public int ZhuravlyovVasyl { set; get; }
        public int ZelenskiyVolodymr { set; get; }
        public int KaplinSergiy { set; get; }
        public int KarmazinYrii { set; get; }
        public int KyvaIlya { set; get; }
        public int CornatskiyArkadiy { set; get; }
        public int KoshylunskiyRuslan { set; get; }
        public int KruvenkoViktor { set; get; }
        public int KupriyVitaliy { set; get; }
        public int LytvynenkoYlia { set; get; }
        public int LyashkoOleg { set; get; }
        public int MorozOleksandr { set; get; }
        public int NaluvaichenkoValentin { set; get; }
        public int NasirovRoman { set; get; }
        public int NovakAndriy { set; get; }
        public int NosenkoSergiy { set; get; }
        public int PetrovVolodymyr { set; get; }
        public int PoroshenkoPetro { set; get; }
        public int RigovanowRuslan { set; get; }
        public int SkotsukVitaliy { set; get; }
        public int SmeshkoIgor { set; get; }
        public int SolovyowOleksandr { set; get; }
        public int TarutaSergiy { set; get; }
        public int TymoshenkoYulia { set; get; }
        public int TymoshenkoYurii { set; get; }
        public int ShewchenkoIgor { set; get; }
        public int ShewchenkoOleksandr { set; get; }
        public string Date { set; get; }
        public int DepHashCode { set; get; }

        public Department(string id, int totalRecievedBul, int numberOfVotersIncluded, int numberOfVotersIncludedPlace, int numberOfUnusedBul, int numberOfVotersRecievedIndoors, int numberOfVotersRecievedAtPlace, int totalNumberVoters, int numberOfBulNotConsider, int totalNumberVotersVoting, int numberOfBulInvalid, int balshowGenadiy, int bezsmertniyRoman, int bogomoletzOlga, int bogoslovskaInna, int boykoYrii, int bondarViktor, int vaschenkoOleksandr, int vilkulOleksandr, int gaberMykola, int grytsenkoAnatoliy, int danulyukOleksandr, int derevyankoYrii, int zhuravlyovVasyl, int zelenskiyVolodymr, int kaplinSergiy, int karmazinYrii, int kyvaIlya, int cornatskiyArkadiy, int koshylunskiyRuslan, int kruvenkoViktor, int kupriyVitaliy, int lytvynenkoYlia, int lyashkoOleg, int morozOleksandr, int naluvaichenkoValentin, int nasirovRoman, int novakAndriy, int nosenkoSergiy, int petrovVolodymyr, int poroshenkoPetro, int rigovanowRuslan, int skotsukVitaliy, int smeshkoIgor, int solovyowOleksandr, int tarutaSergiy, int tymoshenkoYulia, int tymoshenkoYurii, int shewchenkoIgor, int shewchenkoOleksandr, string date)
        {
            Id = id;
            TotalRecievedBul = totalRecievedBul;
            NumberOfVotersIncluded = numberOfVotersIncluded;
            NumberOfVotersIncludedPlace = numberOfVotersIncludedPlace;
            NumberOfUnusedBul = numberOfUnusedBul;
            NumberOfVotersRecievedIndoors = numberOfVotersRecievedIndoors;
            NumberOfVotersRecievedAtPlace = numberOfVotersRecievedAtPlace;
            TotalNumberVoters = totalNumberVoters;
            NumberOfBulNotConsider = numberOfBulNotConsider;
            TotalNumberVotersVoting = totalNumberVotersVoting;
            NumberOfBulInvalid = numberOfBulInvalid;
            BalshowGenadiy = balshowGenadiy;
            BezsmertniyRoman = bezsmertniyRoman;
            BogomoletzOlga = bogomoletzOlga;
            BogoslovskaInna = bogoslovskaInna;
            BoykoYrii = boykoYrii;
            BondarViktor = bondarViktor;
            VaschenkoOleksandr = vaschenkoOleksandr;
            VilkulOleksandr = vilkulOleksandr;
            GaberMykola = gaberMykola;
            GrytsenkoAnatoliy = grytsenkoAnatoliy;
            DanulyukOleksandr = danulyukOleksandr;
            DerevyankoYrii = derevyankoYrii;
            ZhuravlyovVasyl = zhuravlyovVasyl;
            ZelenskiyVolodymr = zelenskiyVolodymr;
            KaplinSergiy = kaplinSergiy;
            KarmazinYrii = karmazinYrii;
            KyvaIlya = kyvaIlya;
            CornatskiyArkadiy = cornatskiyArkadiy;
            KoshylunskiyRuslan = koshylunskiyRuslan;
            KruvenkoViktor = kruvenkoViktor;
            KupriyVitaliy = kupriyVitaliy;
            LytvynenkoYlia = lytvynenkoYlia;
            LyashkoOleg = lyashkoOleg;
            MorozOleksandr = morozOleksandr;
            NaluvaichenkoValentin = naluvaichenkoValentin;
            NasirovRoman = nasirovRoman;
            NovakAndriy = novakAndriy;
            NosenkoSergiy = nosenkoSergiy;
            PetrovVolodymyr = petrovVolodymyr;
            PoroshenkoPetro = poroshenkoPetro;
            RigovanowRuslan = rigovanowRuslan;
            SkotsukVitaliy = skotsukVitaliy;
            SmeshkoIgor = smeshkoIgor;
            SolovyowOleksandr = solovyowOleksandr;
            TarutaSergiy = tarutaSergiy;
            TymoshenkoYulia = tymoshenkoYulia;
            TymoshenkoYurii = tymoshenkoYurii;
            ShewchenkoIgor = shewchenkoIgor;
            ShewchenkoOleksandr = shewchenkoOleksandr;
            Date = date;
            DepHashCode = GetHashCode();
        }

        
        public override int GetHashCode()
        {
            var hashCode = -1171506039;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + TotalRecievedBul.GetHashCode();
            hashCode = hashCode * -1521134295 + NumberOfVotersIncluded.GetHashCode();
            hashCode = hashCode * -1521134295 + NumberOfVotersIncludedPlace.GetHashCode();
            hashCode = hashCode * -1521134295 + NumberOfUnusedBul.GetHashCode();
            hashCode = hashCode * -1521134295 + NumberOfVotersRecievedIndoors.GetHashCode();
            hashCode = hashCode * -1521134295 + NumberOfVotersRecievedAtPlace.GetHashCode();
            hashCode = hashCode * -1521134295 + TotalNumberVoters.GetHashCode();
            hashCode = hashCode * -1521134295 + NumberOfBulNotConsider.GetHashCode();
            hashCode = hashCode * -1521134295 + TotalNumberVotersVoting.GetHashCode();
            hashCode = hashCode * -1521134295 + NumberOfBulInvalid.GetHashCode();
            hashCode = hashCode * -1521134295 + BalshowGenadiy.GetHashCode();
            hashCode = hashCode * -1521134295 + BezsmertniyRoman.GetHashCode();
            hashCode = hashCode * -1521134295 + BogomoletzOlga.GetHashCode();
            hashCode = hashCode * -1521134295 + BogoslovskaInna.GetHashCode();
            hashCode = hashCode * -1521134295 + BoykoYrii.GetHashCode();
            hashCode = hashCode * -1521134295 + BondarViktor.GetHashCode();
            hashCode = hashCode * -1521134295 + VaschenkoOleksandr.GetHashCode();
            hashCode = hashCode * -1521134295 + VilkulOleksandr.GetHashCode();
            hashCode = hashCode * -1521134295 + GaberMykola.GetHashCode();
            hashCode = hashCode * -1521134295 + GrytsenkoAnatoliy.GetHashCode();
            hashCode = hashCode * -1521134295 + DanulyukOleksandr.GetHashCode();
            hashCode = hashCode * -1521134295 + DerevyankoYrii.GetHashCode();
            hashCode = hashCode * -1521134295 + ZhuravlyovVasyl.GetHashCode();
            hashCode = hashCode * -1521134295 + ZelenskiyVolodymr.GetHashCode();
            hashCode = hashCode * -1521134295 + KaplinSergiy.GetHashCode();
            hashCode = hashCode * -1521134295 + KarmazinYrii.GetHashCode();
            hashCode = hashCode * -1521134295 + KyvaIlya.GetHashCode();
            hashCode = hashCode * -1521134295 + CornatskiyArkadiy.GetHashCode();
            hashCode = hashCode * -1521134295 + KoshylunskiyRuslan.GetHashCode();
            hashCode = hashCode * -1521134295 + KruvenkoViktor.GetHashCode();
            hashCode = hashCode * -1521134295 + KupriyVitaliy.GetHashCode();
            hashCode = hashCode * -1521134295 + LytvynenkoYlia.GetHashCode();
            hashCode = hashCode * -1521134295 + LyashkoOleg.GetHashCode();
            hashCode = hashCode * -1521134295 + MorozOleksandr.GetHashCode();
            hashCode = hashCode * -1521134295 + NaluvaichenkoValentin.GetHashCode();
            hashCode = hashCode * -1521134295 + NasirovRoman.GetHashCode();
            hashCode = hashCode * -1521134295 + NovakAndriy.GetHashCode();
            hashCode = hashCode * -1521134295 + NosenkoSergiy.GetHashCode();
            hashCode = hashCode * -1521134295 + PetrovVolodymyr.GetHashCode();
            hashCode = hashCode * -1521134295 + PoroshenkoPetro.GetHashCode();
            hashCode = hashCode * -1521134295 + RigovanowRuslan.GetHashCode();
            hashCode = hashCode * -1521134295 + SkotsukVitaliy.GetHashCode();
            hashCode = hashCode * -1521134295 + SmeshkoIgor.GetHashCode();
            hashCode = hashCode * -1521134295 + SolovyowOleksandr.GetHashCode();
            hashCode = hashCode * -1521134295 + TarutaSergiy.GetHashCode();
            hashCode = hashCode * -1521134295 + TymoshenkoYulia.GetHashCode();
            hashCode = hashCode * -1521134295 + TymoshenkoYurii.GetHashCode();
            hashCode = hashCode * -1521134295 + ShewchenkoIgor.GetHashCode();
            hashCode = hashCode * -1521134295 + ShewchenkoOleksandr.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Date);
            return hashCode;
        }

        public override bool Equals(object obj)
        {
            return obj is Department department &&
                   Id == department.Id;
        }
    }
}
