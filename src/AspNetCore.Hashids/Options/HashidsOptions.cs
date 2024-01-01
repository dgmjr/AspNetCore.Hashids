namespace AspNetCore.Hashids.Options
{
    public record class HashidsOptions
    {
        /// <summary>
        /// Salt (Default "")
        /// </summary>
        /// <default />
        public string Salt { get; set; } = "";

        /// <summary>
        /// MinHashLength (Default value 0)
        /// </summary>
        /// <default>0</default>
        public int MinHashLength { get; set; } = 0;

        /// <summary>
        /// Alphabet (Default value "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890")
        /// </summary>
        /// <default>abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890</default>
        public string Alphabet { get; set; } = HashidsNet.Hashids.DEFAULT_ALPHABET;

        /// <summary>
        /// Steps (Default "cfhistuCFHISTU")
        /// </summary>
        /// <default>cfhistuCFHISTU</default>
        public string Steps { get; set; } = HashidsNet.Hashids.DEFAULT_SEPS;

        /// <summary>
        /// Specify if non hashed-ids are allowed on the request. Default is true.
        /// </summary>
        /// <default>true</default>
        public bool AcceptNonHashedIds { get; set; } = true;
    }
}
