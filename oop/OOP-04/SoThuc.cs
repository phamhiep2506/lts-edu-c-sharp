class SoThuc
{
    private double giaTri;
    private bool laSoDuong;

    public double GiaTri {
        get { return giaTri; }
        set { giaTri = value; }
    }
    public bool LaSoDuong {
        get { return laSoDuong; }
        private set { laSoDuong = value;}
    }

    public SoThuc(double giaTri)
    { 
        GiaTri = giaTri;
        if(giaTri > 0)
        {
            LaSoDuong = true;
        }
        else
        {
            LaSoDuong = false;
        }
    }

    public double TimMax(double so1, double so2, double so3)
    {
        double[] numArray = { so1, so2, so3 };
        return numArray.Max();
    }
    
    public double TinhCanBacN(int bac)
    {
        return Math.Pow(GiaTri, 1.0 / bac);
    }
}
