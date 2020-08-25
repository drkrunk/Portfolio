using System;
using System.Drawing;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class mainForm : Form
    {
        private GameManager gameManager;

        public mainForm()
        {
            InitializeComponent();
            gameManager = new GameManager(this);
        }

        public void FlipDealerCard(Card card) {
            PictureBox image = flowLayoutPanelDealer.Controls[0] as PictureBox;

            String imageString = card.ToString();
            string path2 = System.IO.Path.GetFullPath("images/cards/" + imageString + ".png");
            image.Image = Image.FromFile(path2);
        }

        public void ClearTable() {
            flowLayoutPanelDealer.Controls.Clear();
            flowLayoutPanelPlayer.Controls.Clear();
        }

        public void UpdateGUI() {
            if (gameManager == null) return;
            labelLoses.Text = "Loses:" + gameManager.Loses;
            labelWin.Text = "Wins:" + gameManager.Wins;
        }

        public void DisableGUI() {
            hitButton.Enabled = false;
            standButton.Enabled = false;
            dealButton.Enabled = true;
        }
        public void EnableGUI() {
            hitButton.Enabled = true;
            standButton.Enabled = true;
            dealButton.Enabled = false;
        }

        public void DisplayNewCard(int player, Card card, bool faceDown) {
            PictureBox image = new PictureBox();
            image.Size = new Size(98, 150);
            image.SizeMode = PictureBoxSizeMode.StretchImage;
            image.Anchor = AnchorStyles.None;

            String imageString = card.ToString();


            string path1 = System.IO.Path.GetFullPath("images/cards/back.png");
            string path2 = System.IO.Path.GetFullPath("images/cards/"+ imageString + ".png");

            if (faceDown)
                image.Image = Image.FromFile(path1);
            else
                image.Image = Image.FromFile(path2);



            if (player == 1)
            {
                image.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                flowLayoutPanelDealer.Controls.Add(image);
            }

            else
            { 
                flowLayoutPanelPlayer.Controls.Add(image); 
            }

        }

        private void onHitButtonClick(object sender, EventArgs e)
        {
            gameManager.Draw();
        }

        private void onNewClicked(object sender, EventArgs e)
        {
            ClearTable();
            this.gameManager = new GameManager(this);
            labelLoses.Text = "Loses:0";
            labelWin.Text = "Wins:0";
        }
        private void onStandButtonClicked(object sender, EventArgs e)
        {
            gameManager.EndTurn();
        }

        private void onDealButtonClicked(object sender, EventArgs e)
        {
            UpdateGUI();
            gameManager.NewRound();
            EnableGUI();
        }

        //EWW Flicking Fix 
        //Copied and Pasted from" https://stackoverflow.com/questions/2612487/how-to-fix-the-flickering-in-user-controls
        //By Hans Passant
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void onCloseButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
