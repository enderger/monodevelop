// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.AspNet.Deployment {
    
    
    public partial class WebDeployLaunchDialog {
        
        private Gtk.Label titleLabel;
        
        private Gtk.Label label1;
        
        private Gtk.ScrolledWindow scrolledwindow4;
        
        private Gtk.TreeView targetView;
        
        private Gtk.Button button6;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonDeploy;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.AspNet.Deployment.WebDeployLaunchDialog
            this.Name = "MonoDevelop.AspNet.Deployment.WebDeployLaunchDialog";
            this.Title = MonoDevelop.Core.GettextCatalog.GetString("Deploy to Web");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.Modal = true;
            this.BorderWidth = ((uint)(9));
            // Internal child MonoDevelop.AspNet.Deployment.WebDeployLaunchDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.Spacing = 6;
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.titleLabel = new Gtk.Label();
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Xalign = 0F;
            this.titleLabel.LabelProp = MonoDevelop.Core.GettextCatalog.GetString("<big><b>Deploying Web Project...</b></big>");
            this.titleLabel.UseMarkup = true;
            w1.Add(this.titleLabel);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(w1[this.titleLabel]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.Xalign = 0F;
            this.label1.LabelProp = MonoDevelop.Core.GettextCatalog.GetString("Targets to which the project should be deployed:");
            w1.Add(this.label1);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(w1[this.label1]));
            w3.Position = 1;
            w3.Expand = false;
            w3.Fill = false;
            w3.Padding = ((uint)(4));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.scrolledwindow4 = new Gtk.ScrolledWindow();
            this.scrolledwindow4.CanFocus = true;
            this.scrolledwindow4.Name = "scrolledwindow4";
            this.scrolledwindow4.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow4.Gtk.Container+ContainerChild
            this.targetView = new Gtk.TreeView();
            this.targetView.CanFocus = true;
            this.targetView.Name = "targetView";
            this.scrolledwindow4.Add(this.targetView);
            w1.Add(this.scrolledwindow4);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(w1[this.scrolledwindow4]));
            w5.Position = 2;
            // Internal child MonoDevelop.AspNet.Deployment.WebDeployLaunchDialog.ActionArea
            Gtk.HButtonBox w6 = this.ActionArea;
            w6.Name = "dialog1_ActionArea";
            w6.Spacing = 6;
            w6.BorderWidth = ((uint)(5));
            w6.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.button6 = new Gtk.Button();
            this.button6.CanFocus = true;
            this.button6.Name = "button6";
            this.button6.UseUnderline = true;
            // Container child button6.Gtk.Container+ContainerChild
            Gtk.Alignment w7 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w8 = new Gtk.HBox();
            w8.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w9 = new Gtk.Image();
            w9.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-edit", Gtk.IconSize.Menu, 16);
            w8.Add(w9);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w11 = new Gtk.Label();
            w11.LabelProp = MonoDevelop.Core.GettextCatalog.GetString("_Edit targets");
            w11.UseUnderline = true;
            w8.Add(w11);
            w7.Add(w8);
            this.button6.Add(w7);
            this.AddActionWidget(this.button6, -11);
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w16 = ((Gtk.ButtonBox.ButtonBoxChild)(w6[this.buttonCancel]));
            w16.Position = 1;
            w16.Expand = false;
            w16.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonDeploy = new Gtk.Button();
            this.buttonDeploy.CanDefault = true;
            this.buttonDeploy.CanFocus = true;
            this.buttonDeploy.Name = "buttonDeploy";
            this.buttonDeploy.UseUnderline = true;
            // Container child buttonDeploy.Gtk.Container+ContainerChild
            Gtk.Alignment w17 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment2.Gtk.Container+ContainerChild
            Gtk.HBox w18 = new Gtk.HBox();
            w18.Spacing = 2;
            // Container child GtkHBox2.Gtk.Container+ContainerChild
            Gtk.Image w19 = new Gtk.Image();
            w19.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-ok", Gtk.IconSize.Menu, 16);
            w18.Add(w19);
            // Container child GtkHBox2.Gtk.Container+ContainerChild
            Gtk.Label w21 = new Gtk.Label();
            w21.LabelProp = MonoDevelop.Core.GettextCatalog.GetString("_Deploy");
            w21.UseUnderline = true;
            w18.Add(w21);
            w17.Add(w18);
            this.buttonDeploy.Add(w17);
            this.AddActionWidget(this.buttonDeploy, -5);
            Gtk.ButtonBox.ButtonBoxChild w25 = ((Gtk.ButtonBox.ButtonBoxChild)(w6[this.buttonDeploy]));
            w25.Position = 2;
            w25.Expand = false;
            w25.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 511;
            this.DefaultHeight = 353;
            this.Show();
            this.button6.Clicked += new System.EventHandler(this.editTargetsClicked);
        }
    }
}
