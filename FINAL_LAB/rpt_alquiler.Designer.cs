
namespace FINAL_LAB
{
    partial class rpt_alquiler
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
            this.data_vew = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_vew)).BeginInit();
            this.SuspendLayout();
            // 
            // data_vew
            // 
            this.data_vew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_vew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_vew.Location = new System.Drawing.Point(0, 0);
            this.data_vew.Name = "data_vew";
            this.data_vew.Size = new System.Drawing.Size(745, 264);
            this.data_vew.TabIndex = 0;
            this.data_vew.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rpt_alquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(745, 264);
            this.Controls.Add(this.data_vew);
            this.Name = "rpt_alquiler";
            this.Text = "Reporte de Alquiler";
            this.Load += new System.EventHandler(this.rpt_alquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_vew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_vew;
    }
}