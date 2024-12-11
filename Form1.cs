namespace EU_Auction_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateQuantityComment();
            updateTargetMarkupComment();
            //labelTargetMarkupComment.Text = string.Empty;
        }

        private void updateQuantityComment()
        {
            // Update Quantity comment with min-max
            var lowestQuantity = Math.Floor(numericQuantity.Value * (1 - numericToleranceP.Value / 100));
            if (lowestQuantity == 0) { lowestQuantity = 1; }

            var newText = lowestQuantity.ToString() + " - " + numericQuantity.Value.ToString();
            labelQuantityComment.Text = newText;
        }

        private void updateTargetMarkupComment()
        {
            // Update Markup comment with min-max
            var lowestMarkup = Math.Round(numericTargetMarkupP.Value * (1 - numericTolerancePt.Value / 100), 2);
            var highestMarkup = Math.Round(numericTargetMarkupP.Value * (1 + numericTolerancePt.Value / 100), 2);

            var newText = lowestMarkup.ToString() + " - " + highestMarkup.ToString();
            labelTargetMarkupComment.Text = newText;
        }

        private void updateDataGridView()
        {
            int itemQuantity = (int)numericQuantity.Value; // Totalt antal objekt
            double itemValue = (double)numericValue.Value; // Totalt värde av alla objekt (PED)
            double targetMarkupPercent = (double)numericTargetMarkupP.Value; // Önskad markup i procent
            double targetMarkupTolerance = (double)numericTolerancePt.Value; // Tolerans för markup i procentenheter
            double quantityTolerancePercent = (double)numericToleranceP.Value; // Tolerans för kvantitet i procent
            int maxResults = 10; // Max antal resultat att returnera

            double unitValue = itemValue / itemQuantity; // Värde per enhet
            int minAllowedQuantity = (int)Math.Floor(itemQuantity * (1 - quantityTolerancePercent / 100));
            var results = new List<Result>();

            for (int i = itemQuantity; i >= minAllowedQuantity; i--)
            {
                double totalValue = i * unitValue;

                // Beräkna det ideala PED-värdet baserat på önskad markup
                double idealTotalValuePED = totalValue * (targetMarkupPercent / 100);

                // Börja från det närmaste avrundade värdet av idealTotalValuePED
                int minTotalValuePED = (int)Math.Floor(idealTotalValuePED);
                int maxTotalValuePED = (int)Math.Ceiling(idealTotalValuePED);

                // Testa PED-värden inom ett rimligt spann (+/- 2 för säkerhet)
                for (int totalValuePED = minTotalValuePED - 2; totalValuePED <= maxTotalValuePED + 2; totalValuePED++)
                {
                    if (totalValuePED <= 0) continue; // PED-värden måste vara positiva

                    double markupPED = (totalValuePED / totalValue) * 100;

                    // Debugging: Visa markup med det testade PED-värdet
                    Console.WriteLine($"i: {i}, TotalValue: {totalValue:F2}, TotalValuePED: {totalValuePED}, MarkupPED: {markupPED:F2}");

                    if (Math.Abs(markupPED - targetMarkupPercent) <= targetMarkupTolerance)
                    {
                        results.Add(new Result
                        {
                            Quantity = i,
                            MarkupPercent = Math.Round(markupPED, 2),
                            Diff = Math.Abs(Math.Round(markupPED - targetMarkupPercent, 2)),
                            TotalValuePED = totalValuePED
                        });
                    }

                    if (results.Count >= maxResults)
                    {
                        break;
                    }
                }

                if (results.Count >= maxResults)
                {
                    break;
                }
            }



            // Rensa DataGridView för att undvika att lägga till dubbletter
            dataGridView1.Rows.Clear();

            // Sortera baserat på Diff (stigande) och Quantity (fallande)
            var sortedResults = results
                .OrderBy(r => Math.Abs(r.Diff)) // Första sortering: Diff (stigande)
                .ThenByDescending(r => r.Quantity) // Andra sortering: Quantity (fallande)
                .ToList();

            // Lägg till resultat i DataGridView
            foreach (var result in sortedResults)
            {
                dataGridView1.Rows.Add(result.Quantity, result.MarkupPercent, result.Diff, result.TotalValuePED);
            }
        }

        class Result
        {
            public int Quantity { get; set; }
            public double MarkupPercent { get; set; }
            public double Diff { get; set; }
            public int TotalValuePED { get; set; }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            updateQuantityComment();
            updateDataGridView();
        }

        private void numericToleranceP_ValueChanged(object sender, EventArgs e)
        {
            updateQuantityComment();
            updateDataGridView();
        }

        private void numericTargetMarkupP_ValueChanged(object sender, EventArgs e)
        {
            updateTargetMarkupComment();
            updateDataGridView();
        }

        private void numericTolerancePt_ValueChanged(object sender, EventArgs e)
        {
            updateTargetMarkupComment();
            updateDataGridView();
        }

        private void numericValue_ValueChanged(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
