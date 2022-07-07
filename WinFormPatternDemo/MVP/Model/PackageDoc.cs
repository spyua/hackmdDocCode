namespace MVP.Model
{
    /// <summary>
    /// Package Doc Model
    /// </summary>
    public class PackageDoc
    {
        /// <summary>
        /// 產品名稱
        /// </summary>
        public string ProductName { get; set; }
        
        /// <summary>
        /// 單據號
        /// </summary>
        public string DocNo { get; set; }
        
        /// <summary>
        /// 產量
        /// </summary>
        public int Yield { get; set; }

        /// <summary>
        /// 產量NG數目
        /// </summary>
        public int NGYield { get; set; }

    }
}
