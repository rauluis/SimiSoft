
namespace SimiSoft2
{
    partial class frmNVenta
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNVenta));
            this.gpCliente = new DevExpress.XtraEditors.GroupControl();
            this.luCliente = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gpCodigo = new DevExpress.XtraEditors.GroupControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblCambio = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblPago = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lblDesc = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblSub = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gcVentaDetalle = new DevExpress.XtraGrid.GridControl();
            this.gvVentaDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gpCliente)).BeginInit();
            this.gpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpCodigo)).BeginInit();
            this.gpCodigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcVentaDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentaDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // gpCliente
            // 
            this.gpCliente.Controls.Add(this.luCliente);
            this.gpCliente.Controls.Add(this.labelControl1);
            this.gpCliente.Location = new System.Drawing.Point(12, 12);
            this.gpCliente.Name = "gpCliente";
            this.gpCliente.ShowCaption = false;
            this.gpCliente.Size = new System.Drawing.Size(1040, 53);
            this.gpCliente.TabIndex = 0;
            // 
            // luCliente
            // 
            this.luCliente.Location = new System.Drawing.Point(66, 6);
            this.luCliente.Name = "luCliente";
            this.luCliente.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.luCliente.Properties.Appearance.Options.UseFont = true;
            this.luCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luCliente.Properties.NullText = "";
            this.luCliente.Size = new System.Drawing.Size(273, 36);
            this.luCliente.TabIndex = 1;
            this.luCliente.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cliente:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // gpCodigo
            // 
            this.gpCodigo.Controls.Add(this.txtCodigo);
            this.gpCodigo.Controls.Add(this.labelControl2);
            this.gpCodigo.Location = new System.Drawing.Point(12, 71);
            this.gpCodigo.Name = "gpCodigo";
            this.gpCodigo.ShowCaption = false;
            this.gpCodigo.Size = new System.Drawing.Size(1040, 56);
            this.gpCodigo.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(66, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F);
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Size = new System.Drawing.Size(273, 48);
            this.txtCodigo.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Codigo:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblCambio);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.lblPago);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.lblTotal);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.lblDesc);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.lblSub);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Location = new System.Drawing.Point(12, 622);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1040, 100);
            this.groupControl1.TabIndex = 2;
            // 
            // lblCambio
            // 
            this.lblCambio.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCambio.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.lblCambio.Appearance.Options.UseFont = true;
            this.lblCambio.Appearance.Options.UseForeColor = true;
            this.lblCambio.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCambio.Location = new System.Drawing.Point(854, 44);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(181, 29);
            this.lblCambio.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(741, 49);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(107, 24);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Su Cambio";
            // 
            // lblPago
            // 
            this.lblPago.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPago.Appearance.Options.UseFont = true;
            this.lblPago.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblPago.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblPago.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.lblPago.Location = new System.Drawing.Point(854, 5);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(181, 29);
            this.lblPago.TabIndex = 7;
            this.lblPago.Click += new System.EventHandler(this.labelControl10_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(766, 9);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(82, 24);
            this.labelControl9.TabIndex = 6;
            this.labelControl9.Text = "Su Pago";
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Appearance.Options.UseFont = true;
            this.lblTotal.Appearance.Options.UseForeColor = true;
            this.lblTotal.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTotal.Location = new System.Drawing.Point(575, 10);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(164, 33);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(519, 16);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(50, 24);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "Total";
            // 
            // lblDesc
            // 
            this.lblDesc.Appearance.Font = new System.Drawing.Font("Tahoma", 14.5F);
            this.lblDesc.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblDesc.Appearance.Options.UseFont = true;
            this.lblDesc.Appearance.Options.UseForeColor = true;
            this.lblDesc.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDesc.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblDesc.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.lblDesc.Location = new System.Drawing.Point(376, 7);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(137, 36);
            this.lblDesc.TabIndex = 3;
            this.lblDesc.Click += new System.EventHandler(this.lblDesc_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(264, 15);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(106, 24);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Descuento";
            // 
            // lblSub
            // 
            this.lblSub.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblSub.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblSub.Appearance.Options.UseFont = true;
            this.lblSub.Appearance.Options.UseForeColor = true;
            this.lblSub.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSub.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblSub.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.lblSub.Location = new System.Drawing.Point(97, 6);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(161, 38);
            this.lblSub.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(2, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(89, 24);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "SubTotal";
            // 
            // gcVentaDetalle
            // 
            this.gcVentaDetalle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            gridLevelNode1.RelationName = "Level1";
            this.gcVentaDetalle.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcVentaDetalle.Location = new System.Drawing.Point(12, 133);
            this.gcVentaDetalle.MainView = this.gvVentaDetalle;
            this.gcVentaDetalle.Name = "gcVentaDetalle";
            this.gcVentaDetalle.Size = new System.Drawing.Size(1040, 483);
            this.gcVentaDetalle.TabIndex = 3;
            this.gcVentaDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVentaDetalle});
            // 
            // gvVentaDetalle
            // 
            this.gvVentaDetalle.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gvVentaDetalle.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gvVentaDetalle.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gvVentaDetalle.Appearance.FocusedRow.Options.UseFont = true;
            this.gvVentaDetalle.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.gvVentaDetalle.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvVentaDetalle.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gvVentaDetalle.Appearance.Row.Options.UseFont = true;
            this.gvVentaDetalle.GridControl = this.gcVentaDetalle;
            this.gvVentaDetalle.Name = "gvVentaDetalle";
            this.gvVentaDetalle.OptionsSelection.MultiSelect = true;
            this.gvVentaDetalle.OptionsView.ColumnAutoWidth = false;
            this.gvVentaDetalle.OptionsView.EnableAppearanceOddRow = true;
            this.gvVentaDetalle.OptionsView.ShowFooter = true;
            this.gvVentaDetalle.OptionsView.ShowGroupPanel = false;
            // 
            // frmNVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 734);
            this.Controls.Add(this.gcVentaDetalle);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gpCodigo);
            this.Controls.Add(this.gpCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmNVenta.IconOptions.LargeImage")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva Venta";
            this.Load += new System.EventHandler(this.frmNVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpCliente)).EndInit();
            this.gpCliente.ResumeLayout(false);
            this.gpCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpCodigo)).EndInit();
            this.gpCodigo.ResumeLayout(false);
            this.gpCodigo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcVentaDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentaDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gpCliente;
        private DevExpress.XtraEditors.LookUpEdit luCliente;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl gpCodigo;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblPago;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl lblDesc;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblSub;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl gcVentaDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVentaDetalle;
        private DevExpress.XtraEditors.LabelControl lblCambio;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}