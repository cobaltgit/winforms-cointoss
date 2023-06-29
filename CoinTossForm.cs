using System.Diagnostics;
using System.Security.Cryptography;

namespace CoinToss
{
    public partial class CoinTossForm : Form
    {
        private string[] Outcomes = new string[2] { "Heads", "Tails" };
        private Bitmap[] CoinSides = new Bitmap[2] { Properties.Resources.Heads, Properties.Resources.Tails };

        private Random Rand = new Random();

        private int OutcomeIdx;
        private String Result;

        public CoinTossForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void CoinTossForm_Load(object sender, EventArgs e)
        {
            Coin.Image = CoinSides[Rand.Next(0, CoinSides.Length)];
            OutcomeIdx = Array.FindIndex(CoinSides, image => image == Coin.Image);
        }

        private void TossButton_Click(object sender, EventArgs e)
        {
            String CoinResult = TossCoin();
            MessageBox.Show($"You flipped a coin and got {CoinResult}!", "Coin Toss");
        }

        private void Cycle()
        {
            OutcomeIdx = Rand.Next(0, Outcomes.Length);
            Coin.Image = CoinSides[OutcomeIdx];
            Result = Outcomes[OutcomeIdx];
        }

        private string TossCoin()
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            do
            {
                Cycle();
            } while ( sw.ElapsedMilliseconds < Rand.Next(2, 5) * 1000 );
            return Result;
        }
    }
}