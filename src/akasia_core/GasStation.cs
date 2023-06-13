namespace akasia_core;

public class GasStation
{
    public VehicleType Type { get; set; }
    public GasolineType GasolineType { get; set; }

    public StationType StationType {get; set;}
    public int StationCount { get; set; }
    
}

public enum GasolineType
{
    Pertalite,
    Pertamax,
    PertamaxTurbo
}

public enum VehicleType
{
    TwoWheeler,
    FourWheeler
}

public enum StationType
{
    PertaliteStation,
    PertamaxStation,
    PertamaxTurboStation
}
