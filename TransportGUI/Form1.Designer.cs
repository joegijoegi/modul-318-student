namespace TransportGUI
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
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.ddlStartstation = new System.Windows.Forms.ComboBox();
            this.ddlEndstation = new System.Windows.Forms.ComboBox();
            this.btnSearchStartStation = new System.Windows.Forms.Button();
            this.btnSearchEndStation = new System.Windows.Forms.Button();
            this.btnSearchConnection = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAbfahrtsTafel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(12, 9);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(29, 13);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "Von:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(328, 9);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(36, 13);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "Nach:";
            // 
            // ddlStartstation
            // 
            this.ddlStartstation.FormattingEnabled = true;
            this.ddlStartstation.Location = new System.Drawing.Point(47, 6);
            this.ddlStartstation.Name = "ddlStartstation";
            this.ddlStartstation.Size = new System.Drawing.Size(275, 21);
            this.ddlStartstation.TabIndex = 2;
            // 
            // ddlEndstation
            // 
            this.ddlEndstation.FormattingEnabled = true;
            this.ddlEndstation.Location = new System.Drawing.Point(370, 6);
            this.ddlEndstation.Name = "ddlEndstation";
            this.ddlEndstation.Size = new System.Drawing.Size(275, 21);
            this.ddlEndstation.TabIndex = 3;
            // 
            // btnSearchStartStation
            // 
            this.btnSearchStartStation.Location = new System.Drawing.Point(47, 48);
            this.btnSearchStartStation.Name = "btnSearchStartStation";
            this.btnSearchStartStation.Size = new System.Drawing.Size(275, 23);
            this.btnSearchStartStation.TabIndex = 4;
            this.btnSearchStartStation.Text = "Passende Verbindung suchen";
            this.btnSearchStartStation.UseVisualStyleBackColor = true;
            // 
            // btnSearchEndStation
            // 
            this.btnSearchEndStation.Location = new System.Drawing.Point(370, 48);
            this.btnSearchEndStation.Name = "btnSearchEndStation";
            this.btnSearchEndStation.Size = new System.Drawing.Size(275, 23);
            this.btnSearchEndStation.TabIndex = 5;
            this.btnSearchEndStation.Text = "Passende Verbindung suchen";
            this.btnSearchEndStation.UseVisualStyleBackColor = true;
            // 
            // btnSearchConnection
            // 
            this.btnSearchConnection.Location = new System.Drawing.Point(247, 91);
            this.btnSearchConnection.Name = "btnSearchConnection";
            this.btnSearchConnection.Size = new System.Drawing.Size(183, 23);
            this.btnSearchConnection.TabIndex = 6;
            this.btnSearchConnection.Text = "Verbindung suchen";
            this.btnSearchConnection.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(633, 254);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(570, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Beenden";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnAbfahrtsTafel
            // 
            this.btnAbfahrtsTafel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbfahrtsTafel.Location = new System.Drawing.Point(12, 415);
            this.btnAbfahrtsTafel.Name = "btnAbfahrtsTafel";
            this.btnAbfahrtsTafel.Size = new System.Drawing.Size(75, 23);
            this.btnAbfahrtsTafel.TabIndex = 9;
            this.btnAbfahrtsTafel.Text = "Abfahrtstafel";
            this.btnAbfahrtsTafel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.btnAbfahrtsTafel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearchConnection);
            this.Controls.Add(this.btnSearchEndStation);
            this.Controls.Add(this.btnSearchStartStation);
            this.Controls.Add(this.ddlEndstation);
            this.Controls.Add(this.ddlStartstation);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Name = "Form1";
            this.Text = "Abfahrtsplan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.ComboBox ddlStartstation;
        private System.Windows.Forms.ComboBox ddlEndstation;
        private System.Windows.Forms.Button btnSearchStartStation;
        private System.Windows.Forms.Button btnSearchEndStation;
        private System.Windows.Forms.Button btnSearchConnection;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAbfahrtsTafel;
    }
}

