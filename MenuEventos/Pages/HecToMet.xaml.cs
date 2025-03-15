namespace MenuEventos.Pages;

public partial class HecToMet : ContentPage
{
	public HecToMet()
	{
		InitializeComponent();
	}
    private void btnSubmitOnClicked(object sender, EventArgs e)
    {
        int entity = 0;
        int backup = 0;

        backup = int.Parse(etrInsert.Text);
        entity = int.Parse(etrInsert.Text) * 10000;

        etrAnswer.Text = entity.ToString();

        DisplayAlert("RESULTADO",
            $"{backup} convertido em metros quadrados resulta em: {entity}",
            "Ok");
    }
    private void btnCleanOnClicked(object sender, EventArgs e)
    {
        etrInsert.Text = "";
        etrAnswer.Text = "";
    }

}