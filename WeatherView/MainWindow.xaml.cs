using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO;
using System.Reflection;
using System.Windows.Threading;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace WeatherView
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class _0H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public int TMP2m { get; set; }
        public double DPT2m { get; set; }
        public object WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public int PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _10H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public double TMP2m { get; set; }
        public double DPT2m { get; set; }
        public object WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public double PRMSL { get; set; }
        public double APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _11H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public double TMP2m { get; set; }
        public double DPT2m { get; set; }
        public object WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public double PRMSL { get; set; }
        public double APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _12H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public double TMP2m { get; set; }
        public double DPT2m { get; set; }
        public object WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public double PRMSL { get; set; }
        public double APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _13H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public double TMP2m { get; set; }
        public double DPT2m { get; set; }
        public object WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public double PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _14H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public double TMP2m { get; set; }
        public double DPT2m { get; set; }
        public object WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public double PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _15H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public double TMP2m { get; set; }
        public double DPT2m { get; set; }
        public object WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public double PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _16H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public double TMP2m { get; set; }
        public double DPT2m { get; set; }
        public object WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public double PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _17H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public int TMP2m { get; set; }
        public double DPT2m { get; set; }
        public object WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public double PRMSL { get; set; }
        public double APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _18H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public double TMP2m { get; set; }
        public double DPT2m { get; set; }
        public object WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public double PRMSL { get; set; }
        public double APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _19H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public double TMP2m { get; set; }
        public double DPT2m { get; set; }
        public object WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public double PRMSL { get; set; }
        public double APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _1H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public double TMP2m { get; set; }
        public double DPT2m { get; set; }
        public object WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public double PRMSL { get; set; }
        public double APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _20H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public double TMP2m { get; set; }
        public double DPT2m { get; set; }
        public object WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public double PRMSL { get; set; }
        public double APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _21H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public double TMP2m { get; set; }
        public double DPT2m { get; set; }
        public object WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public double PRMSL { get; set; }
        public double APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _22H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public double TMP2m { get; set; }
        public double DPT2m { get; set; }
        public object WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public double PRMSL { get; set; }
        public double APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _23H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public double TMP2m { get; set; }
        public double DPT2m { get; set; }
        public object WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public double PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _2H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public double TMP2m { get; set; }
        public double DPT2m { get; set; }
        public object WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public double PRMSL { get; set; }
        public double APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _3H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public double TMP2m { get; set; }
        public double DPT2m { get; set; }
        public object WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public double PRMSL { get; set; }
        public double APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _4H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public double TMP2m { get; set; }
        public double DPT2m { get; set; }
        public object WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public double PRMSL { get; set; }
        public double APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _5H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public double TMP2m { get; set; }
        public double DPT2m { get; set; }
        public object WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public double PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _6H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public double TMP2m { get; set; }
        public double DPT2m { get; set; }
        public object WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public double PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _7H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public double TMP2m { get; set; }
        public double DPT2m { get; set; }
        public object WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public double PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _8H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public int TMP2m { get; set; }
        public double DPT2m { get; set; }
        public object WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public double PRMSL { get; set; }
        public double APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _9H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public double TMP2m { get; set; }
        public double DPT2m { get; set; }
        public object WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public double PRMSL { get; set; }
        public double APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class CityInfo
    {
        public string name { get; set; }
        public string country { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string elevation { get; set; }
        public string sunrise { get; set; }
        public string sunset { get; set; }
    }

    public class CurrentCondition
    {
        public string date { get; set; }
        public string hour { get; set; }
        public int tmp { get; set; }
        public int wnd_spd { get; set; }
        public int wnd_gust { get; set; }
        public string wnd_dir { get; set; }
        public double pressure { get; set; }
        public int humidity { get; set; }
        public string condition { get; set; }
        public string condition_key { get; set; }
        public string icon { get; set; }
        public string icon_big { get; set; }
    }

    public class FcstDay0
    {
        public string date { get; set; }
        public string day_short { get; set; }
        public string day_long { get; set; }
        public int tmin { get; set; }
        public int tmax { get; set; }
        public string condition { get; set; }
        public string condition_key { get; set; }
        public string icon { get; set; }
        public string icon_big { get; set; }
        public HourlyData hourly_data { get; set; }
    }

    public class FcstDay1
    {
        public string date { get; set; }
        public string day_short { get; set; }
        public string day_long { get; set; }
        public int tmin { get; set; }
        public int tmax { get; set; }
        public string condition { get; set; }
        public string condition_key { get; set; }
        public string icon { get; set; }
        public string icon_big { get; set; }
        public HourlyData hourly_data { get; set; }
    }

    public class FcstDay2
    {
        public string date { get; set; }
        public string day_short { get; set; }
        public string day_long { get; set; }
        public int tmin { get; set; }
        public int tmax { get; set; }
        public string condition { get; set; }
        public string condition_key { get; set; }
        public string icon { get; set; }
        public string icon_big { get; set; }
        public HourlyData hourly_data { get; set; }
    }

    public class FcstDay3
    {
        public string date { get; set; }
        public string day_short { get; set; }
        public string day_long { get; set; }
        public int tmin { get; set; }
        public int tmax { get; set; }
        public string condition { get; set; }
        public string condition_key { get; set; }
        public string icon { get; set; }
        public string icon_big { get; set; }
        public HourlyData hourly_data { get; set; }
    }

    public class FcstDay4
    {
        public string date { get; set; }
        public string day_short { get; set; }
        public string day_long { get; set; }
        public int tmin { get; set; }
        public int tmax { get; set; }
        public string condition { get; set; }
        public string condition_key { get; set; }
        public string icon { get; set; }
        public string icon_big { get; set; }
        public HourlyData hourly_data { get; set; }
    }

    public class ForecastInfo
    {
        public object latitude { get; set; }
        public object longitude { get; set; }
        public string elevation { get; set; }
    }

    public class HourlyData
    {
        public _0H00 _0H00 { get; set; }
        public _1H00 _1H00 { get; set; }
        public _2H00 _2H00 { get; set; }
        public _3H00 _3H00 { get; set; }
        public _4H00 _4H00 { get; set; }
        public _5H00 _5H00 { get; set; }
        public _6H00 _6H00 { get; set; }
        public _7H00 _7H00 { get; set; }
        public _8H00 _8H00 { get; set; }
        public _9H00 _9H00 { get; set; }
        public _10H00 _10H00 { get; set; }
        public _11H00 _11H00 { get; set; }
        public _12H00 _12H00 { get; set; }
        public _13H00 _13H00 { get; set; }
        public _14H00 _14H00 { get; set; }
        public _15H00 _15H00 { get; set; }
        public _16H00 _16H00 { get; set; }
        public _17H00 _17H00 { get; set; }
        public _18H00 _18H00 { get; set; }
        public _19H00 _19H00 { get; set; }
        public _20H00 _20H00 { get; set; }
        public _21H00 _21H00 { get; set; }
        public _22H00 _22H00 { get; set; }
        public _23H00 _23H00 { get; set; }
    }

    public class Root
    {
        public CityInfo city_info { get; set; }
        public ForecastInfo forecast_info { get; set; }
        public CurrentCondition current_condition { get; set; }
        public FcstDay0 fcst_day_0 { get; set; }
        public FcstDay1 fcst_day_1 { get; set; }
        public FcstDay2 fcst_day_2 { get; set; }
        public FcstDay3 fcst_day_3 { get; set; }
        public FcstDay4 fcst_day_4 { get; set; }
    }



    public partial class MainWindow : Window
    {
        string previousCity;

        int seconds = 0;
        DispatcherTimer timer;
        CityBoxManager cityboxmanager = new CityBoxManager();

        string filePath = Path.Combine("..", "..", "..", "Files", "FavoriteCities.txt");
        public MainWindow()
          {
            InitializeComponent();
            //     _ = DataGrabber(city);
            cityboxmanager.ComboBox_CitiesFunction(filePath);
            Initialize_Timer();
        }

        public async Task<Root> DataGrabber(string city)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("https://www.prevision-meteo.ch/services/json/" + city);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Root root = JsonConvert.DeserializeObject<Root>(content);
                    GetWeather(root);
                    return root;
                    
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        private void GetWeather(Root root)
        {
            try
            {
                CurrentCondition currentcondition = root.current_condition;
                FcstDay0 TodayForecast = root.fcst_day_0;
                FcstDay1 ForecastDay1 = root.fcst_day_1;
                FcstDay2 ForecastDay2 = root.fcst_day_2;
                FcstDay3 ForecastDay3 = root.fcst_day_3;

                Uri resourceUri = new Uri(currentcondition.icon_big, UriKind.Absolute);

                TB_City.Text = root.city_info.name.ToString();
                TB_Date.Text = currentcondition.date.ToString();
                TB_Day.Text = TodayForecast.day_long.ToString();

                TB_Temperature.Text = currentcondition.tmp.ToString();

                WeatherImage.Source = new BitmapImage(resourceUri);
                TB_MaxTemperature.Text = TodayForecast.tmax.ToString() + "°C";
                TB_MinTemperature.Text = TodayForecast.tmin.ToString() + "°C";
                TB_WeatherState.Text = currentcondition.condition.ToString();
                TB_Humidity.Text = currentcondition.humidity.ToString() + "%";
                TB_WindSpeed.Text = currentcondition.wnd_spd.ToString() + " km/h";
                TB_Sunrise.Text = root.city_info.sunrise.ToString();
                TB_Sunset.Text = root.city_info.sunset.ToString();


                TB_Day1MinMax.Text = ForecastDay1.day_short + " " + ForecastDay1.tmin.ToString() + " / " + ForecastDay1.tmax.ToString();
                TB_Day2MinMax.Text = ForecastDay2.day_short + " " + ForecastDay2.tmin.ToString() + " / " + ForecastDay2.tmax.ToString();
                TB_Day3MinMax.Text = ForecastDay3.day_short + " " + ForecastDay3.tmin.ToString() + " / " + ForecastDay3.tmax.ToString();
                Uri ForecastDay1Icon = new Uri(ForecastDay1.icon_big, UriKind.Absolute);
                Uri ForecastDay2Icon = new Uri(ForecastDay2.icon_big, UriKind.Absolute);
                Uri ForecastDay3Icon = new Uri(ForecastDay3.icon_big, UriKind.Absolute);
                WeatherDay1.Source = new BitmapImage(ForecastDay1Icon);
                WeatherDay2.Source = new BitmapImage(ForecastDay2Icon);
                WeatherDay3.Source = new BitmapImage(ForecastDay3Icon);
            }
            catch (Exception ex)
            {
           //  Handle exceptions, log, or display an error message
               string city = previousCity;
               DataGrabber(city);
            }
        }

        private void FavoriteButton_Click(object sender, RoutedEventArgs e)
        {
            string currentCity = TB_City.Text;

            string filePath = Path.Combine("..", "..", "..", "Files", "FavoriteCities.txt");

            string fullPath = Path.GetFullPath(filePath);

            List<string> existingCities = File.ReadLines(fullPath).Select(city => city.Trim()).ToList();

            bool cityExists = existingCities.Exists(city => city.Equals(currentCity, StringComparison.OrdinalIgnoreCase));

            if (cityExists)
            {
                existingCities.Remove(currentCity);
            }
            else
            {
                existingCities.Add(currentCity);
            }
            File.WriteAllLines(fullPath, existingCities);
            ComboBox_Initializer();
        }
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            previousCity = TB_City.Text;
            DataGrabber(SearchBox.Text);
            SearchBox.Text = "Search...";

        }

        private void SearchBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (SearchBox.Text == "Search...")
            {
                SearchBox.Text = "";
            }
        }
        private void ComboBox_Initializer()
        {
            string[] lines = File.ReadAllLines(filePath);

            ComboBox_Cities.ItemsSource = lines;
        }
        private void ComboBox_Cities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string city = ComboBox_Cities.SelectedItem.ToString();
            DataGrabber(city);

        }

        public void Initialize_Timer()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        public void Timer_Tick(object sender, EventArgs e)
        {
            seconds++;
            Debug.WriteLine(seconds);
            if (seconds >= 60)
            {
                seconds = 0;
                ResetData();
                Debug.WriteLine("Resetting to 0");
            }
        }

        public void ResetData()
        {
            DataGrabber(TB_City.Text);
        }

        string NameFilePath = Path.Combine("..", "..", "..", "Files", "Name.txt");
        private void TB_Name_GotFocus(object sender, RoutedEventArgs e)
        {
            string[] lines = File.ReadAllLines(NameFilePath);
            string Name = lines.FirstOrDefault();

            if (TB_Name.Text == Name)
            {
                TB_Name.Text = "";
            }
        }

        private void TB_Name_LostFocus(object sender, RoutedEventArgs e)
        {
            string[] lines = File.ReadAllLines(NameFilePath);
            if (TB_Name.Text.Length > 0)
            {
                string Name = TB_Name.Text;
                File.WriteAllText(NameFilePath, Name);
            }
            else
            {
                string Name = lines.FirstOrDefault();
                TB_Name.Text = Name;
            }
        }
    }


    public class CityBoxManager
    {
        string city;
        public MainWindow mainWindow;
        public CityBoxManager()
        {
        }

        public ComboBox ComboBox_Cities { get; set; }
        public void ComboBox_CitiesFunction(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                ComboBox_Cities.ItemsSource = lines;
                if (lines.Length > 0)
                {
                    ComboBox_Cities.ItemsSource = lines;
                    string firstCity = lines.FirstOrDefault();

                    mainWindow.DataGrabber(firstCity);
                }
                else
                {
                    city = "Paris";
                    mainWindow.DataGrabber(city);
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
