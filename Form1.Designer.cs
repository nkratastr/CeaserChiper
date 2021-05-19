
namespace CeaserChiper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbxPlainText = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbxChiperText = new System.Windows.Forms.TextBox();
            this.btnChiper = new System.Windows.Forms.Button();
            this.btnDechiper = new System.Windows.Forms.Button();
            this.lbxCeaserRotIndex = new System.Windows.Forms.ListBox();
            this.chrtCeaserChiperFreqency = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDrawGraph = new System.Windows.Forms.Button();
            this.lblRotationNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chrtCeaserChiperFreqency)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxPlainText
            // 
            this.tbxPlainText.Location = new System.Drawing.Point(28, 62);
            this.tbxPlainText.MaxLength = 1000000;
            this.tbxPlainText.Multiline = true;
            this.tbxPlainText.Name = "tbxPlainText";
            this.tbxPlainText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxPlainText.Size = new System.Drawing.Size(314, 300);
            this.tbxPlainText.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbxChiperText
            // 
            this.tbxChiperText.Location = new System.Drawing.Point(433, 62);
            this.tbxChiperText.MaxLength = 1000000;
            this.tbxChiperText.Multiline = true;
            this.tbxChiperText.Name = "tbxChiperText";
            this.tbxChiperText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxChiperText.Size = new System.Drawing.Size(314, 300);
            this.tbxChiperText.TabIndex = 2;
            // 
            // btnChiper
            // 
            this.btnChiper.Location = new System.Drawing.Point(32, 13);
            this.btnChiper.Name = "btnChiper";
            this.btnChiper.Size = new System.Drawing.Size(124, 39);
            this.btnChiper.TabIndex = 3;
            this.btnChiper.Text = "Chiper";
            this.btnChiper.UseVisualStyleBackColor = true;
            this.btnChiper.Click += new System.EventHandler(this.btnChiper_Click);
            // 
            // btnDechiper
            // 
            this.btnDechiper.Location = new System.Drawing.Point(179, 13);
            this.btnDechiper.Name = "btnDechiper";
            this.btnDechiper.Size = new System.Drawing.Size(120, 39);
            this.btnDechiper.TabIndex = 4;
            this.btnDechiper.Text = "Dechiper";
            this.btnDechiper.UseVisualStyleBackColor = true;
            this.btnDechiper.Click += new System.EventHandler(this.btnDechiper_Click);
            // 
            // lbxCeaserRotIndex
            // 
            this.lbxCeaserRotIndex.FormattingEnabled = true;
            this.lbxCeaserRotIndex.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29"});
            this.lbxCeaserRotIndex.Location = new System.Drawing.Point(351, 13);
            this.lbxCeaserRotIndex.Name = "lbxCeaserRotIndex";
            this.lbxCeaserRotIndex.ScrollAlwaysVisible = true;
            this.lbxCeaserRotIndex.Size = new System.Drawing.Size(79, 43);
            this.lbxCeaserRotIndex.TabIndex = 5;
            this.lbxCeaserRotIndex.Tag = "";
            // 
            // chrtCeaserChiperFreqency
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtCeaserChiperFreqency.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtCeaserChiperFreqency.Legends.Add(legend1);
            this.chrtCeaserChiperFreqency.Location = new System.Drawing.Point(28, 388);
            this.chrtCeaserChiperFreqency.Name = "chrtCeaserChiperFreqency";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Turkish General";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Given Text";
            this.chrtCeaserChiperFreqency.Series.Add(series1);
            this.chrtCeaserChiperFreqency.Series.Add(series2);
            this.chrtCeaserChiperFreqency.Size = new System.Drawing.Size(719, 256);
            this.chrtCeaserChiperFreqency.TabIndex = 6;
            this.chrtCeaserChiperFreqency.Text = "chart1";
            // 
            // btnDrawGraph
            // 
            this.btnDrawGraph.Location = new System.Drawing.Point(647, 12);
            this.btnDrawGraph.Name = "btnDrawGraph";
            this.btnDrawGraph.Size = new System.Drawing.Size(100, 39);
            this.btnDrawGraph.TabIndex = 7;
            this.btnDrawGraph.Text = "Draw Graph";
            this.btnDrawGraph.UseVisualStyleBackColor = true;
            this.btnDrawGraph.Click += new System.EventHandler(this.btnDrawGraph_Click);
            // 
            // lblRotationNo
            // 
            this.lblRotationNo.AutoSize = true;
            this.lblRotationNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRotationNo.Location = new System.Drawing.Point(351, 62);
            this.lblRotationNo.Name = "lblRotationNo";
            this.lblRotationNo.Size = new System.Drawing.Size(79, 16);
            this.lblRotationNo.TabIndex = 8;
            this.lblRotationNo.Text = "Rotation No";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 656);
            this.Controls.Add(this.lblRotationNo);
            this.Controls.Add(this.btnDrawGraph);
            this.Controls.Add(this.chrtCeaserChiperFreqency);
            this.Controls.Add(this.lbxCeaserRotIndex);
            this.Controls.Add(this.btnDechiper);
            this.Controls.Add(this.btnChiper);
            this.Controls.Add(this.tbxChiperText);
            this.Controls.Add(this.tbxPlainText);
            this.Name = "Form1";
            this.Text = "Ceaser Chiper&Dechiper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtCeaserChiperFreqency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnChiper;
        private System.Windows.Forms.Button btnDechiper;
        private System.Windows.Forms.ListBox lbxCeaserRotIndex;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtCeaserChiperFreqency;
        public System.Windows.Forms.TextBox tbxPlainText;
        public System.Windows.Forms.TextBox tbxChiperText;
        private System.Windows.Forms.Button btnDrawGraph;
        private System.Windows.Forms.Label lblRotationNo;
    }
}

