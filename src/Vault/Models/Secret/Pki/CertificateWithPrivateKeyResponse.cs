﻿using Newtonsoft.Json;

namespace Vault.Models.Secret.Pki
{
    public class CertificateWithPrivateKeyResponse : CertificateResponse
    {
        [JsonProperty("private_key")]
        public string PrivateKey { get; set; }

        [JsonProperty("private_key_type")]
        public PrivateKeyType PrivateKeyType { get; set; }
    }
}
