// See https://aka.ms/new-console-template for more information
class PhanSo
{
    public float tuSo267, mauSo267;

    public float getMauSo()
    {
        return this.mauSo267;
    }

    public void setMauSo(float mauSo267)
    {
        this.mauSo267 = mauSo267;
    }

    public float getTuSo()
    {
        return this.tuSo267;
    }

    public void setTuSo(float tuSo267)
    {
        this.tuSo267 = tuSo267;
    }

    public PhanSo(float tuSo267, float mauSo267)
    {
        this.tuSo267 = tuSo267;
        this.mauSo267 = mauSo267;
    }

    public PhanSo()
    {
    }

    ~PhanSo() { }
}

class PhepTinh
{
    private PhanSo a267, b267;

    public PhepTinh()
    {
        a267 = new PhanSo();
        b267 = new PhanSo();

        Console.Write("Nhap phan so thu nhat:\nTu so:");
        if (!float.TryParse(Console.ReadLine(), out a267.tuSo267))
            Environment.Exit(0);

        Console.Write("Mau so:");
        if (!float.TryParse(Console.ReadLine(), out a267.mauSo267))
            if (a267.mauSo267 == 0)
                Environment.Exit(0);

        Console.Write("Nhap phan so thu hai:\nTu so:");
        if (!float.TryParse(Console.ReadLine(), out b267.tuSo267))
            Environment.Exit(0);

        Console.Write("Mau so:");
        if (!float.TryParse(Console.ReadLine(), out b267.mauSo267))
            if (b267.mauSo267 == 0)
                Environment.Exit(0);
    }

    private float Cong()
    {
        return ((a267.tuSo267 * b267.mauSo267 + b267.tuSo267 * a267.mauSo267) / (a267.mauSo267 * b267.mauSo267));
    }

    private float Tru()
    {
        return ((a267.tuSo267 * b267.mauSo267 - b267.tuSo267 * a267.mauSo267) / (a267.mauSo267 * b267.mauSo267));
    }

    private float Nhan() {
        return (a267.tuSo267 * b267.tuSo267) / (a267.mauSo267 * b267.mauSo267);
    }

    private float Chia() {
        return (a267.tuSo267 * b267.mauSo267) / (a267.mauSo267 * b267.tuSo267);
    }

    static void Main(string[] args) {
        PhepTinh phepTinh = new PhepTinh();

        Console.WriteLine("Ket qua phep cong: {0}", phepTinh.Cong());
        Console.WriteLine("Ket qua phep tru:{0}", phepTinh.Tru());
        Console.WriteLine("Ket qua phep nhan: {0}", phepTinh.Nhan());
        Console.WriteLine("Ket qua phep chia: {0}", phepTinh.Chia());
    }
}
