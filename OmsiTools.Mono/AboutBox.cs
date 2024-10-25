using System.Reflection;
using System.Windows.Forms;

namespace OmsiTools.Mono;

internal partial class AboutBox : Form
{
    public AboutBox()
    {
        InitializeComponent();

        //  Initialize the AboutBox to display the product information from the assembly information.
        //  Change assembly information settings for your application through either:
        //  - Project->Properties->Application->Assembly Information
        //  - AssemblyInfo.cs
        this.Text = $"About {AssemblyTitle}";
        this.radLabelProductName.Text = AssemblyProduct;
        this.radLabelVersion.Text = $"Version {AssemblyVersion}";
        this.radLabelCopyright.Text = AssemblyCopyright;
        this.radLabelCompanyName.Text = AssemblyCompany;
        this.radTextBoxDescription.Text = AssemblyDescription;
    }


    #region Assembly Attribute Accessors

    private string AssemblyTitle
    {
        get
        {
            // Get all Title attributes on this assembly
            object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
            // If there is at least one Title attribute
            if (attributes.Length <= 0)
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            // Select the first one
            AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
            // If it is not an empty string, return it
            return titleAttribute.Title != "" ? titleAttribute.Title :
                // If there was no Title attribute, or if the Title attribute was the empty string, return the .exe name
                Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
        }
    }

    private string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version.ToString();

    private string AssemblyDescription
    {
        get
        {
            // Get all Description attributes on this assembly
            object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
            // If there aren't any Description attributes, return an empty string
            return attributes.Length == 0 ? "" :
                // If there is a Description attribute, return its value
                ((AssemblyDescriptionAttribute)attributes[0]).Description;
        }
    }

    private string AssemblyProduct
    {
        get
        {
            // Get all Product attributes on this assembly
            object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
            // If there aren't any Product attributes, return an empty string
            return attributes.Length == 0 ? "" :
                // If there is a Product attribute, return its value
                ((AssemblyProductAttribute)attributes[0]).Product;
        }
    }

    private string AssemblyCopyright
    {
        get
        {
            // Get all Copyright attributes on this assembly
            object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
            // If there aren't any Copyright attributes, return an empty string
            return attributes.Length == 0 ? "" :
                // If there is a Copyright attribute, return its value
                ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
        }
    }

    private string AssemblyCompany
    {
        get
        {
            // Get all Company attributes on this assembly
            object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
            // If there aren't any Company attributes, return an empty string
            return attributes.Length == 0 ? "" :
                // If there is a Company attribute, return its value
                ((AssemblyCompanyAttribute)attributes[0]).Company;
        }
    }
    #endregion
}