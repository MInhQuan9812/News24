﻿namespace news24h.CommonData;

using System;
using System.Security.Cryptography;
using System.Text;

public class CommonFunction
{

    public static byte[] GetHash(string inputString)
    {
        using (HashAlgorithm algorithm = SHA256.Create())
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
    }

    public static string GetHashString(string inputString)
    {
        StringBuilder sb = new StringBuilder();
        foreach (byte b in GetHash(inputString))
            sb.Append(b.ToString("X2"));

        return sb.ToString();
    }

    internal static string? GetTeaserFromContent(object post_content, int v)
    {
        throw new NotImplementedException();
    }
}

