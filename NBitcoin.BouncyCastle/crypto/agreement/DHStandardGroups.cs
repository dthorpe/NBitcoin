﻿using System;

using NBitcoin.BouncyCastle.Crypto.Parameters;
using NBitcoin.BouncyCastle.Math;
using NBitcoin.BouncyCastle.Utilities.Encoders;

namespace NBitcoin.BouncyCastle.Crypto.Agreement
{
    /// <summary>Standard Diffie-Hellman groups from various IETF specifications.</summary>
    public class DHStandardGroups
    {
        private static BigInteger FromHex(string hex)
        {
            return new BigInteger(1, Hex.Decode(hex));
        }

        private static DHParameters FromPG(string hexP, string hexG)
        {
            return new DHParameters(FromHex(hexP), FromHex(hexG));
        }

        private static DHParameters FromPGQ(string hexP, string hexG, string hexQ)
        {
            return new DHParameters(FromHex(hexP), FromHex(hexG), FromHex(hexQ));
        }

        /*
         * RFC 2409
         */
        private static readonly string rfc2409_768_p = "FFFFFFFFFFFFFFFFC90FDAA22168C234C4C6628B80DC1CD1"
            + "29024E088A67CC74020BBEA63B139B22514A08798E3404DD" + "EF9519B3CD3A431B302B0A6DF25F14374FE1356D6D51C245"
            + "E485B576625E7EC6F44C42E9A63A3620FFFFFFFFFFFFFFFF";
        private static readonly string rfc2409_768_g = "02";
        public static readonly DHParameters rfc2409_768 = FromPG(rfc2409_768_p, rfc2409_768_g);

        private static readonly string rfc2409_1024_p = "FFFFFFFFFFFFFFFFC90FDAA22168C234C4C6628B80DC1CD1"
            + "29024E088A67CC74020BBEA63B139B22514A08798E3404DD" + "EF9519B3CD3A431B302B0A6DF25F14374FE1356D6D51C245"
            + "E485B576625E7EC6F44C42E9A637ED6B0BFF5CB6F406B7ED" + "EE386BFB5A899FA5AE9F24117C4B1FE649286651ECE65381"
            + "FFFFFFFFFFFFFFFF";
        private static readonly string rfc2409_1024_g = "02";
        public static readonly DHParameters rfc2409_1024 = FromPG(rfc2409_1024_p, rfc2409_1024_g);

        /*
         * RFC 3526
         */
        private static readonly string rfc3526_1536_p = "FFFFFFFFFFFFFFFFC90FDAA22168C234C4C6628B80DC1CD1"
            + "29024E088A67CC74020BBEA63B139B22514A08798E3404DD" + "EF9519B3CD3A431B302B0A6DF25F14374FE1356D6D51C245"
            + "E485B576625E7EC6F44C42E9A637ED6B0BFF5CB6F406B7ED" + "EE386BFB5A899FA5AE9F24117C4B1FE649286651ECE45B3D"
            + "C2007CB8A163BF0598DA48361C55D39A69163FA8FD24CF5F" + "83655D23DCA3AD961C62F356208552BB9ED529077096966D"
            + "670C354E4ABC9804F1746C08CA237327FFFFFFFFFFFFFFFF";
        private static readonly string rfc3526_1536_g = "02";
        public static readonly DHParameters rfc3526_1536 = FromPG(rfc3526_1536_p, rfc3526_1536_g);

        private static readonly string rfc3526_2048_p = "FFFFFFFFFFFFFFFFC90FDAA22168C234C4C6628B80DC1CD1"
            + "29024E088A67CC74020BBEA63B139B22514A08798E3404DD" + "EF9519B3CD3A431B302B0A6DF25F14374FE1356D6D51C245"
            + "E485B576625E7EC6F44C42E9A637ED6B0BFF5CB6F406B7ED" + "EE386BFB5A899FA5AE9F24117C4B1FE649286651ECE45B3D"
            + "C2007CB8A163BF0598DA48361C55D39A69163FA8FD24CF5F" + "83655D23DCA3AD961C62F356208552BB9ED529077096966D"
            + "670C354E4ABC9804F1746C08CA18217C32905E462E36CE3B" + "E39E772C180E86039B2783A2EC07A28FB5C55DF06F4C52C9"
            + "DE2BCBF6955817183995497CEA956AE515D2261898FA0510" + "15728E5A8AACAA68FFFFFFFFFFFFFFFF";
        private static readonly string rfc3526_2048_g = "02";
        public static readonly DHParameters rfc3526_2048 = FromPG(rfc3526_2048_p, rfc3526_2048_g);

        private static readonly string rfc3526_3072_p = "FFFFFFFFFFFFFFFFC90FDAA22168C234C4C6628B80DC1CD1"
            + "29024E088A67CC74020BBEA63B139B22514A08798E3404DD" + "EF9519B3CD3A431B302B0A6DF25F14374FE1356D6D51C245"
            + "E485B576625E7EC6F44C42E9A637ED6B0BFF5CB6F406B7ED" + "EE386BFB5A899FA5AE9F24117C4B1FE649286651ECE45B3D"
            + "C2007CB8A163BF0598DA48361C55D39A69163FA8FD24CF5F" + "83655D23DCA3AD961C62F356208552BB9ED529077096966D"
            + "670C354E4ABC9804F1746C08CA18217C32905E462E36CE3B" + "E39E772C180E86039B2783A2EC07A28FB5C55DF06F4C52C9"
            + "DE2BCBF6955817183995497CEA956AE515D2261898FA0510" + "15728E5A8AAAC42DAD33170D04507A33A85521ABDF1CBA64"
            + "ECFB850458DBEF0A8AEA71575D060C7DB3970F85A6E1E4C7" + "ABF5AE8CDB0933D71E8C94E04A25619DCEE3D2261AD2EE6B"
            + "F12FFA06D98A0864D87602733EC86A64521F2B18177B200C" + "BBE117577A615D6C770988C0BAD946E208E24FA074E5AB31"
            + "43DB5BFCE0FD108E4B82D120A93AD2CAFFFFFFFFFFFFFFFF";
        private static readonly string rfc3526_3072_g = "02";
        public static readonly DHParameters rfc3526_3072 = FromPG(rfc3526_3072_p, rfc3526_3072_g);

        private static readonly string rfc3526_4096_p = "FFFFFFFFFFFFFFFFC90FDAA22168C234C4C6628B80DC1CD1"
            + "29024E088A67CC74020BBEA63B139B22514A08798E3404DD" + "EF9519B3CD3A431B302B0A6DF25F14374FE1356D6D51C245"
            + "E485B576625E7EC6F44C42E9A637ED6B0BFF5CB6F406B7ED" + "EE386BFB5A899FA5AE9F24117C4B1FE649286651ECE45B3D"
            + "C2007CB8A163BF0598DA48361C55D39A69163FA8FD24CF5F" + "83655D23DCA3AD961C62F356208552BB9ED529077096966D"
            + "670C354E4ABC9804F1746C08CA18217C32905E462E36CE3B" + "E39E772C180E86039B2783A2EC07A28FB5C55DF06F4C52C9"
            + "DE2BCBF6955817183995497CEA956AE515D2261898FA0510" + "15728E5A8AAAC42DAD33170D04507A33A85521ABDF1CBA64"
            + "ECFB850458DBEF0A8AEA71575D060C7DB3970F85A6E1E4C7" + "ABF5AE8CDB0933D71E8C94E04A25619DCEE3D2261AD2EE6B"
            + "F12FFA06D98A0864D87602733EC86A64521F2B18177B200C" + "BBE117577A615D6C770988C0BAD946E208E24FA074E5AB31"
            + "43DB5BFCE0FD108E4B82D120A92108011A723C12A787E6D7" + "88719A10BDBA5B2699C327186AF4E23C1A946834B6150BDA"
            + "2583E9CA2AD44CE8DBBBC2DB04DE8EF92E8EFC141FBECAA6" + "287C59474E6BC05D99B2964FA090C3A2233BA186515BE7ED"
            + "1F612970CEE2D7AFB81BDD762170481CD0069127D5B05AA9" + "93B4EA988D8FDDC186FFB7DC90A6C08F4DF435C934063199"
            + "FFFFFFFFFFFFFFFF";
        private static readonly string rfc3526_4096_g = "02";
        public static readonly DHParameters rfc3526_4096 = FromPG(rfc3526_4096_p, rfc3526_4096_g);

        private static readonly string rfc3526_6144_p = "FFFFFFFFFFFFFFFFC90FDAA22168C234C4C6628B80DC1CD129024E08"
            + "8A67CC74020BBEA63B139B22514A08798E3404DDEF9519B3CD3A431B"
            + "302B0A6DF25F14374FE1356D6D51C245E485B576625E7EC6F44C42E9"
            + "A637ED6B0BFF5CB6F406B7EDEE386BFB5A899FA5AE9F24117C4B1FE6"
            + "49286651ECE45B3DC2007CB8A163BF0598DA48361C55D39A69163FA8"
            + "FD24CF5F83655D23DCA3AD961C62F356208552BB9ED529077096966D"
            + "670C354E4ABC9804F1746C08CA18217C32905E462E36CE3BE39E772C"
            + "180E86039B2783A2EC07A28FB5C55DF06F4C52C9DE2BCBF695581718"
            + "3995497CEA956AE515D2261898FA051015728E5A8AAAC42DAD33170D"
            + "04507A33A85521ABDF1CBA64ECFB850458DBEF0A8AEA71575D060C7D"
            + "B3970F85A6E1E4C7ABF5AE8CDB0933D71E8C94E04A25619DCEE3D226"
            + "1AD2EE6BF12FFA06D98A0864D87602733EC86A64521F2B18177B200C"
            + "BBE117577A615D6C770988C0BAD946E208E24FA074E5AB3143DB5BFC"
            + "E0FD108E4B82D120A92108011A723C12A787E6D788719A10BDBA5B26"
            + "99C327186AF4E23C1A946834B6150BDA2583E9CA2AD44CE8DBBBC2DB"
            + "04DE8EF92E8EFC141FBECAA6287C59474E6BC05D99B2964FA090C3A2"
            + "233BA186515BE7ED1F612970CEE2D7AFB81BDD762170481CD0069127"
            + "D5B05AA993B4EA988D8FDDC186FFB7DC90A6C08F4DF435C934028492"
            + "36C3FAB4D27C7026C1D4DCB2602646DEC9751E763DBA37BDF8FF9406"
            + "AD9E530EE5DB382F413001AEB06A53ED9027D831179727B0865A8918"
            + "DA3EDBEBCF9B14ED44CE6CBACED4BB1BDB7F1447E6CC254B33205151"
            + "2BD7AF426FB8F401378CD2BF5983CA01C64B92ECF032EA15D1721D03"
            + "F482D7CE6E74FEF6D55E702F46980C82B5A84031900B1C9E59E7C97F"
            + "BEC7E8F323A97A7E36CC88BE0F1D45B7FF585AC54BD407B22B4154AA"
            + "CC8F6D7EBF48E1D814CC5ED20F8037E0A79715EEF29BE32806A1D58B"
            + "B7C5DA76F550AA3D8A1FBFF0EB19CCB1A313D55CDA56C9EC2EF29632"
            + "387FE8D76E3C0468043E8F663F4860EE12BF2D5B0B7474D6E694F91E"
            + "6DCC4024FFFFFFFFFFFFFFFF";
        private static readonly string rfc3526_6144_g = "02";
        public static readonly DHParameters rfc3526_6144 = FromPG(rfc3526_6144_p, rfc3526_6144_g);

        private static readonly string rfc3526_8192_p = "FFFFFFFFFFFFFFFFC90FDAA22168C234C4C6628B80DC1CD1"
            + "29024E088A67CC74020BBEA63B139B22514A08798E3404DD" + "EF9519B3CD3A431B302B0A6DF25F14374FE1356D6D51C245"
            + "E485B576625E7EC6F44C42E9A637ED6B0BFF5CB6F406B7ED" + "EE386BFB5A899FA5AE9F24117C4B1FE649286651ECE45B3D"
            + "C2007CB8A163BF0598DA48361C55D39A69163FA8FD24CF5F" + "83655D23DCA3AD961C62F356208552BB9ED529077096966D"
            + "670C354E4ABC9804F1746C08CA18217C32905E462E36CE3B" + "E39E772C180E86039B2783A2EC07A28FB5C55DF06F4C52C9"
            + "DE2BCBF6955817183995497CEA956AE515D2261898FA0510" + "15728E5A8AAAC42DAD33170D04507A33A85521ABDF1CBA64"
            + "ECFB850458DBEF0A8AEA71575D060C7DB3970F85A6E1E4C7" + "ABF5AE8CDB0933D71E8C94E04A25619DCEE3D2261AD2EE6B"
            + "F12FFA06D98A0864D87602733EC86A64521F2B18177B200C" + "BBE117577A615D6C770988C0BAD946E208E24FA074E5AB31"
            + "43DB5BFCE0FD108E4B82D120A92108011A723C12A787E6D7" + "88719A10BDBA5B2699C327186AF4E23C1A946834B6150BDA"
            + "2583E9CA2AD44CE8DBBBC2DB04DE8EF92E8EFC141FBECAA6" + "287C59474E6BC05D99B2964FA090C3A2233BA186515BE7ED"
            + "1F612970CEE2D7AFB81BDD762170481CD0069127D5B05AA9" + "93B4EA988D8FDDC186FFB7DC90A6C08F4DF435C934028492"
            + "36C3FAB4D27C7026C1D4DCB2602646DEC9751E763DBA37BD" + "F8FF9406AD9E530EE5DB382F413001AEB06A53ED9027D831"
            + "179727B0865A8918DA3EDBEBCF9B14ED44CE6CBACED4BB1B" + "DB7F1447E6CC254B332051512BD7AF426FB8F401378CD2BF"
            + "5983CA01C64B92ECF032EA15D1721D03F482D7CE6E74FEF6" + "D55E702F46980C82B5A84031900B1C9E59E7C97FBEC7E8F3"
            + "23A97A7E36CC88BE0F1D45B7FF585AC54BD407B22B4154AA" + "CC8F6D7EBF48E1D814CC5ED20F8037E0A79715EEF29BE328"
            + "06A1D58BB7C5DA76F550AA3D8A1FBFF0EB19CCB1A313D55C" + "DA56C9EC2EF29632387FE8D76E3C0468043E8F663F4860EE"
            + "12BF2D5B0B7474D6E694F91E6DBE115974A3926F12FEE5E4" + "38777CB6A932DF8CD8BEC4D073B931BA3BC832B68D9DD300"
            + "741FA7BF8AFC47ED2576F6936BA424663AAB639C5AE4F568" + "3423B4742BF1C978238F16CBE39D652DE3FDB8BEFC848AD9"
            + "22222E04A4037C0713EB57A81A23F0C73473FC646CEA306B" + "4BCBC8862F8385DDFA9D4B7FA2C087E879683303ED5BDD3A"
            + "062B3CF5B3A278A66D2A13F83F44F82DDF310EE074AB6A36" + "4597E899A0255DC164F31CC50846851DF9AB48195DED7EA1"
            + "B1D510BD7EE74D73FAF36BC31ECFA268359046F4EB879F92" + "4009438B481C6CD7889A002ED5EE382BC9190DA6FC026E47"
            + "9558E4475677E9AA9E3050E2765694DFC81F56E880B96E71" + "60C980DD98EDD3DFFFFFFFFFFFFFFFFF";
        private static readonly string rfc3526_8192_g = "02";
        public static readonly DHParameters rfc3526_8192 = FromPG(rfc3526_8192_p, rfc3526_8192_g);

        /*
         * RFC 4306
         */
        public static readonly DHParameters rfc4306_768 = rfc2409_768;
        public static readonly DHParameters rfc4306_1024 = rfc2409_1024;

        /*
         * RFC 5114
         */
        private static readonly string rfc5114_1024_160_p = "B10B8F96A080E01DDE92DE5EAE5D54EC52C99FBCFB06A3C6"
            + "9A6A9DCA52D23B616073E28675A23D189838EF1E2EE652C0" + "13ECB4AEA906112324975C3CD49B83BFACCBDD7D90C4BD70"
            + "98488E9C219A73724EFFD6FAE5644738FAA31A4FF55BCCC0" + "A151AF5F0DC8B4BD45BF37DF365C1A65E68CFDA76D4DA708"
            + "DF1FB2BC2E4A4371";
        private static readonly string rfc5114_1024_160_g = "A4D1CBD5C3FD34126765A442EFB99905F8104DD258AC507F"
            + "D6406CFF14266D31266FEA1E5C41564B777E690F5504F213" + "160217B4B01B886A5E91547F9E2749F4D7FBD7D3B9A92EE1"
            + "909D0D2263F80A76A6A24C087A091F531DBF0A0169B6A28A" + "D662A4D18E73AFA32D779D5918D08BC8858F4DCEF97C2A24"
            + "855E6EEB22B3B2E5";
        private static readonly string rfc5114_1024_160_q = "F518AA8781A8DF278ABA4E7D64B7CB9D49462353";
        public static readonly DHParameters rfc5114_1024_160 = FromPGQ(rfc5114_1024_160_p, rfc5114_1024_160_g,
            rfc5114_1024_160_q);

        private static readonly string rfc5114_2048_224_p = "AD107E1E9123A9D0D660FAA79559C51FA20D64E5683B9FD1"
            + "B54B1597B61D0A75E6FA141DF95A56DBAF9A3C407BA1DF15" + "EB3D688A309C180E1DE6B85A1274A0A66D3F8152AD6AC212"
            + "9037C9EDEFDA4DF8D91E8FEF55B7394B7AD5B7D0B6C12207" + "C9F98D11ED34DBF6C6BA0B2C8BBC27BE6A00E0A0B9C49708"
            + "B3BF8A317091883681286130BC8985DB1602E714415D9330" + "278273C7DE31EFDC7310F7121FD5A07415987D9ADC0A486D"
            + "CDF93ACC44328387315D75E198C641A480CD86A1B9E587E8" + "BE60E69CC928B2B9C52172E413042E9B23F10B0E16E79763"
            + "C9B53DCF4BA80A29E3FB73C16B8E75B97EF363E2FFA31F71" + "CF9DE5384E71B81C0AC4DFFE0C10E64F";
        private static readonly string rfc5114_2048_224_g = "AC4032EF4F2D9AE39DF30B5C8FFDAC506CDEBE7B89998CAF"
            + "74866A08CFE4FFE3A6824A4E10B9A6F0DD921F01A70C4AFA" + "AB739D7700C29F52C57DB17C620A8652BE5E9001A8D66AD7"
            + "C17669101999024AF4D027275AC1348BB8A762D0521BC98A" + "E247150422EA1ED409939D54DA7460CDB5F6C6B250717CBE"
            + "F180EB34118E98D119529A45D6F834566E3025E316A330EF" + "BB77A86F0C1AB15B051AE3D428C8F8ACB70A8137150B8EEB"
            + "10E183EDD19963DDD9E263E4770589EF6AA21E7F5F2FF381" + "B539CCE3409D13CD566AFBB48D6C019181E1BCFE94B30269"
            + "EDFE72FE9B6AA4BD7B5A0F1C71CFFF4C19C418E1F6EC0179" + "81BC087F2A7065B384B890D3191F2BFA";
        private static readonly string rfc5114_2048_224_q = "801C0D34C58D93FE997177101F80535A4738CEBCBF389A99B36371EB";
        public static readonly DHParameters rfc5114_2048_224 = FromPGQ(rfc5114_2048_224_p, rfc5114_2048_224_g,
            rfc5114_2048_224_q);

        private static readonly string rfc5114_2048_256_p = "87A8E61DB4B6663CFFBBD19C651959998CEEF608660DD0F2"
            + "5D2CEED4435E3B00E00DF8F1D61957D4FAF7DF4561B2AA30" + "16C3D91134096FAA3BF4296D830E9A7C209E0C6497517ABD"
            + "5A8A9D306BCF67ED91F9E6725B4758C022E0B1EF4275BF7B" + "6C5BFC11D45F9088B941F54EB1E59BB8BC39A0BF12307F5C"
            + "4FDB70C581B23F76B63ACAE1CAA6B7902D52526735488A0E" + "F13C6D9A51BFA4AB3AD8347796524D8EF6A167B5A41825D9"
            + "67E144E5140564251CCACB83E6B486F6B3CA3F7971506026" + "C0B857F689962856DED4010ABD0BE621C3A3960A54E710C3"
            + "75F26375D7014103A4B54330C198AF126116D2276E11715F" + "693877FAD7EF09CADB094AE91E1A1597";
        private static readonly string rfc5114_2048_256_g = "3FB32C9B73134D0B2E77506660EDBD484CA7B18F21EF2054"
            + "07F4793A1A0BA12510DBC15077BE463FFF4FED4AAC0BB555" + "BE3A6C1B0C6B47B1BC3773BF7E8C6F62901228F8C28CBB18"
            + "A55AE31341000A650196F931C77A57F2DDF463E5E9EC144B" + "777DE62AAAB8A8628AC376D282D6ED3864E67982428EBC83"
            + "1D14348F6F2F9193B5045AF2767164E1DFC967C1FB3F2E55" + "A4BD1BFFE83B9C80D052B985D182EA0ADB2A3B7313D3FE14"
            + "C8484B1E052588B9B7D2BBD2DF016199ECD06E1557CD0915" + "B3353BBB64E0EC377FD028370DF92B52C7891428CDC67EB6"
            + "184B523D1DB246C32F63078490F00EF8D647D148D4795451" + "5E2327CFEF98C582664B4C0F6CC41659";
        private static readonly string rfc5114_2048_256_q = "8CF83642A709A097B447997640129DA299B1A47D1EB3750B"
            + "A308B0FE64F5FBD3";
        public static readonly DHParameters rfc5114_2048_256 = FromPGQ(rfc5114_2048_256_p, rfc5114_2048_256_g,
            rfc5114_2048_256_q);

        /*
         * RFC 5996
         */
        public static readonly DHParameters rfc5996_768 = rfc4306_768;
        public static readonly DHParameters rfc5996_1024 = rfc4306_1024;
    }
}
