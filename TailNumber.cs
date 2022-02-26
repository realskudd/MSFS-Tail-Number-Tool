using Newtonsoft.Json;


namespace MSFS_2020_Tail_Number_Fixer___FSUIPC
{
    [JsonObject(MemberSerialization.OptIn)]
    public class TailNumber
    {
        [JsonProperty]
        public string Registration { get; set; }

        [JsonProperty]
        public string AircraftModel { get; set; }

        public TailNumber() { }

        public TailNumber(string registration, string model)
        {
            Registration = registration;
            AircraftModel = model;
        }

        public override string ToString()
        {
            return $"{Registration} - {AircraftModel}";
        }
    }
}
