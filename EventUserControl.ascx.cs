public partial class EventUserControl : System.Web.UI.UserControl
{
    private string pageTitle;
    public event EventHandler PageTitleUpdated;

    protected void btnUpdatePageTitle_Click(object sender, EventArgs e)
    {
        this.pageTitle = txtPageTitle.Text;
        if(PageTitleUpdated != null)
            PageTitleUpdated(this, EventArgs.Empty);
    }

    public string PageTitle
    {
        get { return pageTitle; }
    }

    protected void MyEventUserControl_PageTitleUpdated(object sender, EventArgs e)
	{
	    this.Title = MyEventUserControl.PageTitle;
	}
	
}
