namespace NFT.Market;

public partial class MainPage : ContentPage
{
    private List<string> _allImages;
    private Random rnd = new Random();

	public List<string> ImageList1 { get; set; }
    public List<string> ImageList2 { get; set; }
    public List<string> ImageList3 { get; set; }
    public List<string> ImageList4 { get; set; }

    public MainPage()
	{
		InitializeComponent();

        GenerateData();

        ImageList1 = Randomize(_allImages);
        ImageList2 = Randomize(_allImages);
        ImageList3 = Randomize(_allImages);
        ImageList4 = Randomize(_allImages);

        BindingContext = this;
	}

    private void GenerateData()
    {
        _allImages = new();

        for (var i = 1; i <= 6; i++)
        {
            _allImages.Add($"img{i.ToString("00")}.png");
        }
    }

    public List<T> Randomize<T>(List<T> source) =>
        source.OrderBy<T, int>((item) => rnd.Next()).ToList();
    
}


