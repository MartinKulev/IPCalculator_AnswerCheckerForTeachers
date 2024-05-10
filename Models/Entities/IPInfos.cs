using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace IPTestFormASP.Models.Entities
{
    public class IPInfos
    {
        public IPInfos()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Name { get; set; }
        public string Number { get; set; }
        public string SchoolClass { get; set; }
        public DateTime TurnedInDateTime { get; set; }
        
        public string IPDec { get; set; }
        public string IPBin { get; set; }
        public char NetworkClass { get; set; }
        public string SMBin { get; set; }
        public string SMDec { get; set; }
        public string NABin { get; set; }
        public string NADec { get; set; }
        public string BRABin { get; set; }
        public string BRADec { get; set; }
        public string Range { get; set; }

        public int SubnetCount { get; set; }

        public string SubnetSMBin { get; set; }
        public string SubnetSMDec { get; set; }

        public string SubnetNABin1 { get; set; }
        public string SubnetNADec1 { get; set; }
        public string SubnetBRABin1 { get; set; }
        public string SubnetBRADec1 { get; set; }
        public string SubnetRange1 { get; set; }

        public string SubnetNABin2 { get; set; }
        public string SubnetNADec2 { get; set; }
        public string SubnetBRABin2 { get; set; }
        public string SubnetBRADec2 { get; set; }
        public string SubnetRange2 { get; set; }

        public string SubnetNABin3 { get; set; }
        public string SubnetNADec3 { get; set; }
        public string SubnetBRABin3 { get; set; }
        public string SubnetBRADec3 { get; set; }
        public string SubnetRange3 { get; set; }

        public string InputIPBin { get; set; }
        public char InputNetworkClass { get; set; }
        public string InputSMBin { get; set; }
        public string InputSMDec { get; set; }
        public string InputNABin { get; set; }
        public string InputNADec { get; set; }
        public string InputBRABin { get; set; }
        public string InputBRADec { get; set; }
        public string InputRange { get; set; }
    
        public string InputSubnetSMBin { get; set; }
        public string InputSubnetSMDec { get; set; }

        public string InputSubnetNABin1 { get; set; }
        public string InputSubnetNADec1 { get; set; }
        public string InputSubnetBRABin1 { get; set; }
        public string InputSubnetBRADec1 { get; set; }
        public string InputSubnetRange1 { get; set; }

        public string InputSubnetNABin2 { get; set; }
        public string InputSubnetNADec2 { get; set; }
        public string InputSubnetBRABin2 { get; set; }
        public string InputSubnetBRADec2 { get; set; }
        public string InputSubnetRange2 { get; set; }

        public string InputSubnetNABin3 { get; set; }
        public string InputSubnetNADec3 { get; set; }
        public string InputSubnetBRABin3 { get; set; }
        public string InputSubnetBRADec3 { get; set; }
        public string InputSubnetRange3 { get; set; }
    }
}

