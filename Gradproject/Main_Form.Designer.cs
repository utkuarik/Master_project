﻿namespace Gradproject
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ave_uti = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ave_mix = new System.Windows.Forms.Label();
            this.ave_sim_neigh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ave_FSI = new System.Windows.Forms.Label();
            this.editex = new System.Windows.Forms.Label();
            this.NDF_emp = new System.Windows.Forms.Label();
            this.NDF_emp_2 = new System.Windows.Forms.Label();
            this.NDF_emp_3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sepera = new System.Windows.Forms.Label();
            this.simu_number = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ndf_11 = new System.Windows.Forms.Label();
            this.ndf_12 = new System.Windows.Forms.Label();
            this.ndf_13 = new System.Windows.Forms.Label();
            this.ndf_21 = new System.Windows.Forms.Label();
            this.ndf_22 = new System.Windows.Forms.Label();
            this.ndf_23 = new System.Windows.Forms.Label();
            this.local_number = new System.Windows.Forms.Label();
            this.minor_number = new System.Windows.Forms.Label();
            this.var_mix = new System.Windows.Forms.Label();
            this.var_asn = new System.Windows.Forms.Label();
            this.var_fsi = new System.Windows.Forms.Label();
            this.min_var = new System.Windows.Forms.Label();
            this.sep_var = new System.Windows.Forms.Label();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.unhloc = new System.Windows.Forms.Label();
            this.unhmin = new System.Windows.Forms.Label();
            this.Ini_mrk_shr = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.eeeee = new System.Windows.Forms.Label();
            this.fin_mrk_sh = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(818, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(818, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Step";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ave_uti
            // 
            this.ave_uti.AutoSize = true;
            this.ave_uti.Location = new System.Drawing.Point(954, 156);
            this.ave_uti.Name = "ave_uti";
            this.ave_uti.Size = new System.Drawing.Size(13, 13);
            this.ave_uti.TabIndex = 2;
            this.ave_uti.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(932, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Average utility:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(932, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Average Mixity:";
            // 
            // ave_mix
            // 
            this.ave_mix.AutoSize = true;
            this.ave_mix.Location = new System.Drawing.Point(954, 204);
            this.ave_mix.Name = "ave_mix";
            this.ave_mix.Size = new System.Drawing.Size(13, 13);
            this.ave_mix.TabIndex = 5;
            this.ave_mix.Text = "0";
            // 
            // ave_sim_neigh
            // 
            this.ave_sim_neigh.AutoSize = true;
            this.ave_sim_neigh.Location = new System.Drawing.Point(1046, 156);
            this.ave_sim_neigh.Name = "ave_sim_neigh";
            this.ave_sim_neigh.Size = new System.Drawing.Size(13, 13);
            this.ave_sim_neigh.TabIndex = 7;
            this.ave_sim_neigh.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1023, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ave Similar Neigh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1035, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Average FSI";
            // 
            // ave_FSI
            // 
            this.ave_FSI.AutoSize = true;
            this.ave_FSI.Location = new System.Drawing.Point(1046, 204);
            this.ave_FSI.Name = "ave_FSI";
            this.ave_FSI.Size = new System.Drawing.Size(13, 13);
            this.ave_FSI.TabIndex = 10;
            this.ave_FSI.Text = "0";
            // 
            // editex
            // 
            this.editex.AutoSize = true;
            this.editex.Location = new System.Drawing.Point(844, 23);
            this.editex.Name = "editex";
            this.editex.Size = new System.Drawing.Size(89, 13);
            this.editex.TabIndex = 11;
            this.editex.Text = "NDF(empty ones)";
            // 
            // NDF_emp
            // 
            this.NDF_emp.AutoSize = true;
            this.NDF_emp.Location = new System.Drawing.Point(880, 48);
            this.NDF_emp.Name = "NDF_emp";
            this.NDF_emp.Size = new System.Drawing.Size(13, 13);
            this.NDF_emp.TabIndex = 12;
            this.NDF_emp.Text = "0";
            // 
            // NDF_emp_2
            // 
            this.NDF_emp_2.AutoSize = true;
            this.NDF_emp_2.Location = new System.Drawing.Point(880, 72);
            this.NDF_emp_2.Name = "NDF_emp_2";
            this.NDF_emp_2.Size = new System.Drawing.Size(13, 13);
            this.NDF_emp_2.TabIndex = 13;
            this.NDF_emp_2.Text = "0";
            // 
            // NDF_emp_3
            // 
            this.NDF_emp_3.AutoSize = true;
            this.NDF_emp_3.Location = new System.Drawing.Point(880, 95);
            this.NDF_emp_3.Name = "NDF_emp_3";
            this.NDF_emp_3.Size = new System.Drawing.Size(13, 13);
            this.NDF_emp_3.TabIndex = 14;
            this.NDF_emp_3.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1035, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Seperatists\r\n\r\n";
            // 
            // sepera
            // 
            this.sepera.AutoSize = true;
            this.sepera.Location = new System.Drawing.Point(1058, 337);
            this.sepera.Name = "sepera";
            this.sepera.Size = new System.Drawing.Size(13, 13);
            this.sepera.TabIndex = 16;
            this.sepera.Text = "0";
            // 
            // simu_number
            // 
            this.simu_number.AutoSize = true;
            this.simu_number.Location = new System.Drawing.Point(954, 274);
            this.simu_number.Name = "simu_number";
            this.simu_number.Size = new System.Drawing.Size(13, 13);
            this.simu_number.TabIndex = 17;
            this.simu_number.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(915, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Simulation number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(946, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "NDF Locals";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1035, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "NDF Minors";
            // 
            // ndf_11
            // 
            this.ndf_11.AutoSize = true;
            this.ndf_11.Location = new System.Drawing.Point(969, 48);
            this.ndf_11.Name = "ndf_11";
            this.ndf_11.Size = new System.Drawing.Size(13, 13);
            this.ndf_11.TabIndex = 21;
            this.ndf_11.Text = "0";
            // 
            // ndf_12
            // 
            this.ndf_12.AutoSize = true;
            this.ndf_12.Location = new System.Drawing.Point(969, 72);
            this.ndf_12.Name = "ndf_12";
            this.ndf_12.Size = new System.Drawing.Size(13, 13);
            this.ndf_12.TabIndex = 22;
            this.ndf_12.Text = "0";
            // 
            // ndf_13
            // 
            this.ndf_13.AutoSize = true;
            this.ndf_13.Location = new System.Drawing.Point(969, 95);
            this.ndf_13.Name = "ndf_13";
            this.ndf_13.Size = new System.Drawing.Size(13, 13);
            this.ndf_13.TabIndex = 23;
            this.ndf_13.Text = "0";
            // 
            // ndf_21
            // 
            this.ndf_21.AutoSize = true;
            this.ndf_21.Location = new System.Drawing.Point(1061, 48);
            this.ndf_21.Name = "ndf_21";
            this.ndf_21.Size = new System.Drawing.Size(13, 13);
            this.ndf_21.TabIndex = 24;
            this.ndf_21.Text = "0";
            // 
            // ndf_22
            // 
            this.ndf_22.AutoSize = true;
            this.ndf_22.Location = new System.Drawing.Point(1060, 72);
            this.ndf_22.Name = "ndf_22";
            this.ndf_22.Size = new System.Drawing.Size(13, 13);
            this.ndf_22.TabIndex = 25;
            this.ndf_22.Text = "0";
            // 
            // ndf_23
            // 
            this.ndf_23.AutoSize = true;
            this.ndf_23.Location = new System.Drawing.Point(1060, 94);
            this.ndf_23.Name = "ndf_23";
            this.ndf_23.Size = new System.Drawing.Size(13, 13);
            this.ndf_23.TabIndex = 26;
            this.ndf_23.Text = "0";
            // 
            // local_number
            // 
            this.local_number.AutoSize = true;
            this.local_number.Location = new System.Drawing.Point(932, 315);
            this.local_number.Name = "local_number";
            this.local_number.Size = new System.Drawing.Size(13, 13);
            this.local_number.TabIndex = 27;
            this.local_number.Text = "0";
            // 
            // minor_number
            // 
            this.minor_number.AutoSize = true;
            this.minor_number.Location = new System.Drawing.Point(932, 337);
            this.minor_number.Name = "minor_number";
            this.minor_number.Size = new System.Drawing.Size(13, 13);
            this.minor_number.TabIndex = 28;
            this.minor_number.Text = "0";
            // 
            // var_mix
            // 
            this.var_mix.AutoSize = true;
            this.var_mix.Location = new System.Drawing.Point(954, 226);
            this.var_mix.Name = "var_mix";
            this.var_mix.Size = new System.Drawing.Size(13, 13);
            this.var_mix.TabIndex = 30;
            this.var_mix.Text = "0";
            // 
            // var_asn
            // 
            this.var_asn.AutoSize = true;
            this.var_asn.Location = new System.Drawing.Point(1046, 178);
            this.var_asn.Name = "var_asn";
            this.var_asn.Size = new System.Drawing.Size(13, 13);
            this.var_asn.TabIndex = 31;
            this.var_asn.Text = "0";
            // 
            // var_fsi
            // 
            this.var_fsi.AutoSize = true;
            this.var_fsi.Location = new System.Drawing.Point(1046, 226);
            this.var_fsi.Name = "var_fsi";
            this.var_fsi.Size = new System.Drawing.Size(13, 13);
            this.var_fsi.TabIndex = 32;
            this.var_fsi.Text = "0";
            // 
            // min_var
            // 
            this.min_var.AutoSize = true;
            this.min_var.Location = new System.Drawing.Point(969, 315);
            this.min_var.Name = "min_var";
            this.min_var.Size = new System.Drawing.Size(13, 13);
            this.min_var.TabIndex = 33;
            this.min_var.Text = "0";
            // 
            // sep_var
            // 
            this.sep_var.AutoSize = true;
            this.sep_var.Location = new System.Drawing.Point(1058, 361);
            this.sep_var.Name = "sep_var";
            this.sep_var.Size = new System.Drawing.Size(13, 13);
            this.sep_var.TabIndex = 34;
            this.sep_var.Text = "0";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Hoverable = true;
            this.cartesianChart1.Location = new System.Drawing.Point(430, 283);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.ScrollHorizontalFrom = 0D;
            this.cartesianChart1.ScrollHorizontalTo = 0D;
            this.cartesianChart1.ScrollMode = LiveCharts.ScrollMode.None;
            this.cartesianChart1.ScrollVerticalFrom = 0D;
            this.cartesianChart1.ScrollVerticalTo = 0D;
            this.cartesianChart1.Size = new System.Drawing.Size(8, 8);
            this.cartesianChart1.TabIndex = 35;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // unhloc
            // 
            this.unhloc.AutoSize = true;
            this.unhloc.Location = new System.Drawing.Point(1038, 248);
            this.unhloc.Name = "unhloc";
            this.unhloc.Size = new System.Drawing.Size(35, 13);
            this.unhloc.TabIndex = 36;
            this.unhloc.Text = "label9";
            // 
            // unhmin
            // 
            this.unhmin.AutoSize = true;
            this.unhmin.Location = new System.Drawing.Point(1038, 274);
            this.unhmin.Name = "unhmin";
            this.unhmin.Size = new System.Drawing.Size(41, 13);
            this.unhmin.TabIndex = 37;
            this.unhmin.Text = "label10";
            // 
            // Ini_mrk_shr
            // 
            this.Ini_mrk_shr.AutoSize = true;
            this.Ini_mrk_shr.Location = new System.Drawing.Point(835, 315);
            this.Ini_mrk_shr.Name = "Ini_mrk_shr";
            this.Ini_mrk_shr.Size = new System.Drawing.Size(13, 13);
            this.Ini_mrk_shr.TabIndex = 38;
            this.Ini_mrk_shr.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(815, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Initial Market Sh.";
            // 
            // eeeee
            // 
            this.eeeee.AutoSize = true;
            this.eeeee.Location = new System.Drawing.Point(818, 337);
            this.eeeee.Name = "eeeee";
            this.eeeee.Size = new System.Drawing.Size(84, 13);
            this.eeeee.TabIndex = 40;
            this.eeeee.Text = "Final Market Sh.";
            // 
            // fin_mrk_sh
            // 
            this.fin_mrk_sh.AutoSize = true;
            this.fin_mrk_sh.Location = new System.Drawing.Point(835, 361);
            this.fin_mrk_sh.Name = "fin_mrk_sh";
            this.fin_mrk_sh.Size = new System.Drawing.Size(13, 13);
            this.fin_mrk_sh.TabIndex = 41;
            this.fin_mrk_sh.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(818, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Price:";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(835, 283);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(13, 13);
            this.price.TabIndex = 43;
            this.price.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 411);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fin_mrk_sh);
            this.Controls.Add(this.eeeee);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Ini_mrk_shr);
            this.Controls.Add(this.unhmin);
            this.Controls.Add(this.unhloc);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.sep_var);
            this.Controls.Add(this.min_var);
            this.Controls.Add(this.var_fsi);
            this.Controls.Add(this.var_asn);
            this.Controls.Add(this.var_mix);
            this.Controls.Add(this.minor_number);
            this.Controls.Add(this.local_number);
            this.Controls.Add(this.ndf_23);
            this.Controls.Add(this.ndf_22);
            this.Controls.Add(this.ndf_21);
            this.Controls.Add(this.ndf_13);
            this.Controls.Add(this.ndf_12);
            this.Controls.Add(this.ndf_11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.simu_number);
            this.Controls.Add(this.sepera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NDF_emp_3);
            this.Controls.Add(this.NDF_emp_2);
            this.Controls.Add(this.NDF_emp);
            this.Controls.Add(this.editex);
            this.Controls.Add(this.ave_FSI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ave_sim_neigh);
            this.Controls.Add(this.ave_mix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ave_uti);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ave_uti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ave_mix;
        private System.Windows.Forms.Label ave_sim_neigh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ave_FSI;
        private System.Windows.Forms.Label editex;
        private System.Windows.Forms.Label NDF_emp;
        private System.Windows.Forms.Label NDF_emp_2;
        private System.Windows.Forms.Label NDF_emp_3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sepera;
        private System.Windows.Forms.Label simu_number;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ndf_11;
        private System.Windows.Forms.Label ndf_12;
        private System.Windows.Forms.Label ndf_13;
        private System.Windows.Forms.Label ndf_21;
        private System.Windows.Forms.Label ndf_22;
        private System.Windows.Forms.Label ndf_23;
        private System.Windows.Forms.Label local_number;
        private System.Windows.Forms.Label minor_number;
        private System.Windows.Forms.Label var_mix;
        private System.Windows.Forms.Label var_asn;
        private System.Windows.Forms.Label var_fsi;
        private System.Windows.Forms.Label min_var;
        private System.Windows.Forms.Label sep_var;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Label unhloc;
        private System.Windows.Forms.Label unhmin;
        private System.Windows.Forms.Label Ini_mrk_shr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label eeeee;
        private System.Windows.Forms.Label fin_mrk_sh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label price;
    }
}