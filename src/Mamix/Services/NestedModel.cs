// File: Services/NestedModel.cs
   public class NestedModel
    {
        public string? Data { get; set; }
        public List<NestedModel> Children { get; set; } = new List<NestedModel>();
    }
