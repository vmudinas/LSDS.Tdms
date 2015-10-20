using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    public class CTM_TradeDetailBodyPartySettlementSettlementInstructions
    {
        [Key]
        public int CtmId { get; set; }

        private string _ID1;
        private string _ID2;
        private string _ID3;
        private string _ID4;
        private string _ID5;
        private string _ParticipantName1;
        private string _ParticipantName2;
        private string _AccountRef1;
        private string _AccountRef2;
        private string _SecurityAccount;
        private string _SubAccountRef1;
        private string _SubAccountRef2;
        private string _SubAccountNo;
        private string _PaymentCurrency;
        private string _CashAccountNo;
        private string _AlternateCurrency;
        private string _AlternateCashAccountNo;
        private string _CustodianBIC;
        private string _CustodianName1;
        private string _CustodianName2;
        private string _CustodianAddress1;
        private string _CustodianAddress2;
        private string _CustodianCity;
        private string _CustodianLocality;
        private string _CustodianCountry;
        private string _CustodianPostCode;
        private string _SubAgentBIC;
        private string _SubAgentName1;
        private string _SubAgentName2;
        private string _SubAgentAddress1;
        private string _SubAgentAddress2;
        private string _SubAgentCity;
        private string _SubAgentLocality;
        private string _SubAgentCountry;
        private string _SubAgentPostCode;
        private string _CorrespBIC;
        private string _CorrespName1;
        private string _CorrespName2;
        private string _CorrespAddress1;
        private string _CorrespAddress2;
        private string _CorrespCity;
        private string _CorrespLocality;
        private string _CorrespCountry;
        private string _CorrespPostCode;
        private string _CorrespCashAccountNo;
        private string _CorrespSecAccountNo;
        private string _Relationship;
        private string _RegName1;
        private string _PSET;
        private string _RegAddress1;
        private string _RegAddress2;
        private string _RegCity;
        private string _RegLocality;
        private string _RegCountry;
        private string _RegPostCode;
        private string _SettlementContact;
        private string _SettlementPhone;
        private string _SettlementFax;
        private string _SettlementTelex;
        private string _SpecialInstr1;
        private string _SpecialInstr2;
        private string _AffirmingPartyIndicator;
        private string _InstitutionBIC;
        private string _InstitutionContact;
        private string _InstitutionPhone;
        private string _IP1ID;
        private string _IP1BIC;
        private string _IP1AccountNo;
        private string _IP1Name;
        private string _IP1Contact;
        private string _IP1Phone;
        private string _IP1SpecialInstr1;
        private string _IP1SpecialInstr2;
        private string _IP2ID;
        private string _IP2BIC;
        private string _IP2AccountNo;
        private string _IP2Name;
        private string _IP2Contact;
        private string _IP2Phone;
        private string _IP2SpecialInstr1;
        private string _IP2SpecialInstr2;
        private string _IP3ID;
        private string _IP3BIC;
        private string _IP3AccountNo;
        private string _IP3Name;
        private string _IP3Contact;
        private string _IP3Phone;
        private string _IP3SpecialInstr1;
        private string _IP3SpecialInstr2;
        private string _AgentID;
        private string _INSTorBrokerID;
        private string _ReceiverAgentBIC;
        private string _ReceiverAgentName;
        private string _LEI;
        private string _AccountLEI;
        private string _LargeTraderID;

        [MaxLength(35)]
        public string ID1
        {
            get
            {
                return this._ID1;
            }
            set
            {
                this._ID1 = value;
            }
        }
        [MaxLength(35)]
        public string ID2
        {
            get
            {
                return this._ID2;
            }
            set
            {
                this._ID2 = value;
            }
        }
        [MaxLength(35)]
        public string ID3
        {
            get
            {
                return this._ID3;
            }
            set
            {
                this._ID3 = value;
            }
        }
        [MaxLength(35)]
        public string ID4
        {
            get
            {
                return this._ID4;
            }
            set
            {
                this._ID4 = value;
            }
        }
        [MaxLength(35)]
        public string ID5
        {
            get
            {
                return this._ID5;
            }
            set
            {
                this._ID5 = value;
            }
        }
      
        [MaxLength(35)]
        public string AgentID
        {
            get
            {
                return this._AgentID;
            }
            set
            {
                this._AgentID = value;
            }
        }
        [MaxLength(35)]
        public string INSTorBrokerID
        {
            get
            {
                return this._INSTorBrokerID;
            }
            set
            {
                this._INSTorBrokerID = value;
            }
        }
        [MaxLength(35)]
        public string ParticipantName1
        {
            get
            {
                return this._ParticipantName1;
            }
            set
            {
                this._ParticipantName1  = value;
            }
        }
        [MaxLength(35)]
        public string ParticipantName2
        {
            get
            {
                return this._ParticipantName2;
            }
            set
            {
                this._ParticipantName2 = value;
            }
        }
        [MaxLength(35)]
        public string AccountRef1
        {
            get
            {
                return this._AccountRef1;
            }
            set
            {
                this._AccountRef1 = value;
            }
        }
        [MaxLength(35)]
        public string AccountRef2
        {
            get
            {
                return this._AccountRef2;
            }
            set
            {
                this._AccountRef2 = value;
            }
        }

        [MaxLength(35)]
        public string SecurityAccount
        {
            get
            {
                return this._SecurityAccount;
            }
            set
            {
                this._SecurityAccount = value;
            }
        }
        [MaxLength(35)]
        public string SubAccountRef1
        {
            get
            {
                return this._SubAccountRef1;
            }
            set
            {
                this._SubAccountRef1 = value;
            }
        }
        [MaxLength(35)]
        public string SubAccountRef2
        {
            get
            {
                return this._SubAccountRef2;
            }
            set
            {
                this._SubAccountRef2 = value;
            }
        }
        [MaxLength(35)]
        public string SubAccountNo
        {
            get
            {
                return this._SubAccountNo;
            }
            set
            {
                this._SubAccountNo = value;
            }
        }
        [MaxLength(3)]
        public string PaymentCurrency
        {
            get
            {
                return this._PaymentCurrency;
            }
            set
            {
                this._PaymentCurrency = value;
            }
        }
        [MaxLength(35)]
        public string CashAccountNo
        {
            get
            {
                return this._CashAccountNo;
            }
            set
            {
                this._CashAccountNo = value;
            }
        }

        [MaxLength(3)]
        public string AlternateCurrency
        {
            get
            {
                return this._AlternateCurrency;
            }
            set
            {
                this._AlternateCurrency = value;
            }
        }
        [MaxLength(35)]
        public string AlternateCashAccountNo
        {
            get
            {
                return this._AlternateCashAccountNo;
            }
            set
            {
                this._AlternateCashAccountNo = value;
            }
        }
        [MaxLength(11)]
        public string CustodianBIC
        {
            get
            {
                return this._CustodianBIC;
            }
            set
            {
                this._CustodianBIC = value;
            }
        }
        [MaxLength(35)]
        public string CustodianName1
        {
            get
            {
                return this._CustodianName1;
            }
            set
            {
                this._CustodianName1 = value;
            }
        }
        [MaxLength(35)]
        public string CustodianName2
        {
            get
            {
                return this._CustodianName2;
            }
            set
            {
                this._CustodianName2 = value;
            }
        }
        [MaxLength(35)]
        public string CustodianAddress1
        {
            get
            {
                return this._CustodianAddress1;
            }
            set
            {
                this._CustodianAddress1 = value;
            }
        }
        [MaxLength(35)]
        public string CustodianAddress2
        {
            get
            {
                return this._CustodianAddress2;
            }
            set
            {
                this._CustodianAddress2 = value;
            }
        }

        [MaxLength(35)]
        public string CustodianCity
        {
            get
            {
                return this._CustodianCity;
            }
            set
            {
                this._CustodianCity = value;
            }
        }
        [MaxLength(35)]
        public string CustodianLocality
        {
            get
            {
                return this._CustodianLocality;
            }
            set
            {
                this._CustodianLocality = value;
            }
        }

        [MaxLength(2)]
        public string CustodianCountry
        {
            get
            {
                return this._CustodianCountry;
            }
            set
            {
                this._CustodianCountry = value;
            }
        }
        [MaxLength(15)]
        public string CustodianPostCode
        {
            get
            {
                return this._CustodianPostCode;
            }
            set
            {
                this._CustodianPostCode = value;
            }
        }
        [MaxLength(11)]
        public string SubAgentBIC
        {
            get
            {
                return this._SubAgentBIC;
            }
            set
            {
                this._SubAgentBIC = value;
            }
        }

        [MaxLength(35)]
        public string SubAgentName1
        {
            get
            {
                return this._SubAgentName1;
            }
            set
            {
                this._SubAgentName1 = value;
            }
        }
        [MaxLength(35)]
        public string SubAgentName2
        {
            get
            {
                return this._SubAgentName2;
            }
            set
            {
                this._SubAgentName2 = value;
            }
        }
        [MaxLength(35)]
        public string SubAgentAddress1
        {
            get
            {
                return this._SubAgentAddress1;
            }
            set
            {
                this._SubAgentAddress1 = value;
            }
        }
        [MaxLength(35)]
        public string SubAgentAddress2
        {
            get
            {
                return this._SubAgentAddress2;
            }
            set
            {
                this._SubAgentAddress2 = value;
            }
        }
        [MaxLength(35)]
        public string SubAgentCity
        {
            get
            {
                return this._SubAgentCity;
            }
            set
            {
                this._SubAgentCity = value;
            }
        }

        [MaxLength(35)]
        public string SubAgentLocality
        {
            get
            {
                return this._SubAgentLocality;
            }
            set
            {
                this._SubAgentLocality = value;
            }
        }
        [MaxLength(2)]
        public string SubAgentCountry
        {
            get
            {
                return this._SubAgentCountry;
            }
            set
            {
                this._SubAgentCountry = value;
            }
        }
        [MaxLength(15)]
        public string SubAgentPostCode
        {
            get
            {
                return this._SubAgentPostCode;
            }
            set
            {
                this._SubAgentPostCode = value;
            }
        }     


        [MaxLength(11)]
        public string CorrespBIC
        {
            get
            {
                return this._CorrespBIC;
            }
            set
            {
                this._CorrespBIC = value;
            }
        }

        [MaxLength(35)]
        public string CorrespName1
        {
            get
            {
                return this._CorrespName1;
            }
            set
            {
                this._CorrespName1 = value;
            }
        }
        [MaxLength(35)]
        public string CorrespName2
        {
            get
            {
                return this._CorrespName2;
            }
            set
            {
                this._CorrespName2 = value;
            }
        }
        [MaxLength(35)]
        public string CorrespAddress1
        {
            get
            {
                return this._CorrespAddress1;
            }
            set
            {
                this._CorrespAddress1 = value;
            }
        }
        [MaxLength(35)]
        public string CorrespAddress2
        {
            get
            {
                return this._CorrespAddress2;
            }
            set
            {
                this._CorrespAddress2 = value;
            }
        }
        [MaxLength(35)]
        public string CorrespCity
        {
            get
            {
                return this._CorrespCity;
            }
            set
            {
                this._CorrespCity = value;
            }
        }

        [MaxLength(35)]
        public string CorrespLocality
        {
            get
            {
                return this._CorrespLocality;
            }
            set
            {
                this._CorrespLocality = value;
            }
        }
        [MaxLength(2)]
        public string CorrespCountry
        {
            get
            {
                return this._CorrespCountry;
            }
            set
            {
                this._CorrespCountry = value;
            }
        }
        [MaxLength(15)]
        public string CorrespPostCode
        {
            get
            {
                return this._CorrespPostCode;
            }
            set
            {
                this._CorrespPostCode = value;
            }
        }

        [MaxLength(35)]
        public string CorrespCashAccountNo
        {
            get
            {
                return this._CorrespCashAccountNo;
            }
            set
            {
                this._CorrespCashAccountNo = value;
            }
        }

        [MaxLength(35)]
        public string CorrespSecAccountNo
        {
            get
            {
                return this._CorrespSecAccountNo;
            }
            set
            {
                this._CorrespSecAccountNo = value;
            }
        }
        [MaxLength(1)]
        public string Relationship
        {
            get
            {
                return this._Relationship;
            }
            set
            {
                this._Relationship = value;
            }
        }
        [MaxLength(35)]
        public string RegName1
        {
            get
            {
                return this._RegName1;
            }
            set
            {
                this._RegName1 = value;
            }
        }
        [MaxLength(14)]
        public string PSET
        {
            get
            {
                return this._PSET;
            }
            set
            {
                this._PSET = value;
            }
        }
        [MaxLength(35)]
        public string RegAddress1
        {
            get
            {
                return this._RegAddress1;
            }
            set
            {
                this._RegAddress1 = value;
            }
        }

        [MaxLength(35)]
        public string RegAddress2
        {
            get
            {
                return this._RegAddress2;
            }
            set
            {
                this._RegAddress2 = value;
            }
        }

        [MaxLength(35)]
        public string RegCity
        {
            get
            {
                return this._RegCity;
            }
            set
            {
                this._RegCity = value;
            }
        }
        [MaxLength(35)]
        public string RegLocality
        {
            get
            {
                return this._RegLocality;
            }
            set
            {
                this._RegLocality = value;
            }
        }
        [MaxLength(2)]
        public string RegCountry
        {
            get
            {
                return this._RegCountry;
            }
            set
            {
                this._RegCountry = value;
            }
        }

        [MaxLength(15)]
        public string RegPostCode
        {
            get
            {
                return this._RegPostCode;
            }
            set
            {
                this._RegPostCode = value;
            }
        }

        [MaxLength(35)]
        public string SettlementContact
        {
            get
            {
                return this._SettlementContact;
            }
            set
            {
                this._SettlementContact = value;
            }
        }

        [MaxLength(20)]
        public string SettlementPhone
        {
            get
            {
                return this._SettlementPhone;
            }
            set
            {
                this._SettlementPhone = value;
            }
        }
        [MaxLength(20)]
        public string SettlementFax
        {
            get
            {
                return this._SettlementFax;
            }
            set
            {
                this._SettlementFax = value;
            }
        }
        [MaxLength(20)]
        public string SettlementTelex
        {
            get
            {
                return this._SettlementTelex;
            }
            set
            {
                this._SettlementTelex = value;
            }
        }
        [MaxLength(35)]
        public string SpecialInstr1
        {
            get
            {
                return this._SpecialInstr1;
            }
            set
            {
                this._SpecialInstr1 = value;
            }
        }
        [MaxLength(35)]
        public string SpecialInstr2
        {
            get
            {
                return this._SpecialInstr2;
            }
            set
            {
                this._SpecialInstr2 = value;
            }
        }
        [MaxLength(1)]
        public string AffirmingPartyIndicator
        {
            get
            {
                return this._AffirmingPartyIndicator;
            }
            set
            {
                this._AffirmingPartyIndicator = value;
            }
        }

        [MaxLength(11)]
        public string InstitutionBIC
        {
            get
            {
                return this._InstitutionBIC;
            }
            set
            {
                this._InstitutionBIC = value;
            }
        }
        [MaxLength(35)]
        public string InstitutionContact
        {
            get
            {
                return this._InstitutionContact;
            }
            set
            {
                this._InstitutionContact = value;
            }
        }

        [MaxLength(20)]
        public string InstitutionPhone
        {
            get
            {
                return this._InstitutionPhone;
            }
            set
            {
                this._InstitutionPhone = value;
            }
        }

        [MaxLength(8)]
        public string IP1ID
        {
            get
            {
                return this._IP1ID;
            }
            set
            {
                this._IP1ID = value;
            }
        }
        [MaxLength(11)]
        public string IP1BIC
        {
            get
            {
                return this._IP1BIC;
            }
            set
            {
                this._IP1BIC = value;
            }
        }
        [MaxLength(25)]
        public string IP1AccountNo
        {
            get
            {
                return this._IP1AccountNo;
            }
            set
            {
                this._IP1AccountNo = value;
            }
        }
        [MaxLength(35)]
        public string IP1Name
        {
            get
            {
                return this._IP1Name;
            }
            set
            {
                this._IP1Name = value;
            }
        }

        [MaxLength(35)]
        public string IP1Contact
        {
            get
            {
                return this._IP1Contact;
            }
            set
            {
                this._IP1Contact = value;
            }
        }
        [MaxLength(20)]
        public string IP1Phone
        {
            get
            {
                return this._IP1Phone;
            }
            set
            {
                this._IP1Phone = value;
            }
        }
        [MaxLength(35)]
        public string IP1SpecialInstr1
        {
            get
            {
                return this._IP1SpecialInstr1;
            }
            set
            {
                this._IP1SpecialInstr1 = value;
            }
        }
        [MaxLength(35)]
        public string IP1SpecialInstr2
        {
            get
            {
                return this._IP1SpecialInstr2;
            }
            set
            {
                this._IP1SpecialInstr2 = value;
            }
        }
        [MaxLength(8)]
        public string IP2ID
        {
            get
            {
                return this._IP2ID;
            }
            set
            {
                this._IP2ID = value;
            }
        }
        [MaxLength(11)]
        public string IP2BIC
        {
            get
            {
                return this._IP2BIC;
            }
            set
            {
                this._IP2BIC = value;
            }
        }

        [MaxLength(25)]
        public string IP2AccountNo
        {
            get
            {
                return this._IP2AccountNo;
            }
            set
            {
                this._IP2AccountNo = value;
            }
        }
        [MaxLength(35)]
        public string IP2Name
        {
            get
            {
                return this._IP2Name;
            }
            set
            {
                this._IP2Name = value;
            }
        }

        [MaxLength(35)]
        public string IP2Contact
        {
            get
            {
                return this._IP2Contact;
            }
            set
            {
                this._IP2Contact = value;
            }
        }
        [MaxLength(20)]
        public string IP2Phone
        {
            get
            {
                return this._IP2Phone;
            }
            set
            {
                this._IP2Phone = value;
            }
        }
        [MaxLength(35)]
        public string IP2SpecialInstr1
        {
            get
            {
                return this._IP2SpecialInstr1;
            }
            set
            {
                this._IP2SpecialInstr1 = value;
            }
        }
        [MaxLength(35)]
        public string IP2SpecialInstr2
        {
            get
            {
                return this._IP2SpecialInstr2;
            }
            set
            {
                this._IP2SpecialInstr2 = value;
            }
        }
        [MaxLength(8)]
        public string IP3ID
        {
            get
            {
                return this._IP3ID;
            }
            set
            {
                this._IP3ID = value;
            }
        }
        [MaxLength(11)]
        public string IP3BIC
        {
            get
            {
                return this._IP3BIC;
            }
            set
            {
                this._IP3BIC = value;
            }
        }
        [MaxLength(25)]
        public string IP3AccountNo
        {
            get
            {
                return this._IP3AccountNo;
            }
            set
            {
                this._IP3AccountNo = value;
            }
        }
        [MaxLength(35)]
        public string IP3Name
        {
            get
            {
                return this._IP3Name;
            }
            set
            {
                this._IP3Name = value;
            }
        }
        [MaxLength(35)]
        public string IP3Contact
        {
            get
            {
                return this._IP3Contact;
            }
            set
            {
                this._IP3Contact = value;
            }
        }
        [MaxLength(20)]
        public string IP3Phone
        {
            get
            {
                return this._IP3Phone;
            }
            set
            {
                this._IP3Phone = value;
            }
        }
        [MaxLength(35)]
        public string IP3SpecialInstr1
        {
            get
            {
                return this._IP3SpecialInstr1;
            }
            set
            {
                this._IP3SpecialInstr1 = value;
            }
        }
        [MaxLength(35)]
        public string IP3SpecialInstr2
        {
            get
            {
                return this._IP3SpecialInstr2;
            }
            set
            {
                this._IP3SpecialInstr2 = value;
            }
        }
        [MaxLength(11)]
        public string ReceiverAgentBIC
        {
            get
            {
                return this._ReceiverAgentBIC;
            }
            set
            {
                this._ReceiverAgentBIC = value;
            }
        }
        [MaxLength(35)]
        public string ReceiverAgentName
        {
            get
            {
                return this._ReceiverAgentName;
            }
            set
            {
                this._ReceiverAgentName = value;
            }
        }
        [MaxLength(20)]
        public string LEI
        {
            get
            {
                return this._LEI;
            }
            set
            {
                this._LEI = value;
            }
        }
        [MaxLength(35)]
        public string AccountLEI
        {
            get
            {
                return this._AccountLEI;
            }
            set
            {
                this._AccountLEI = value;
            }
        }
        [MaxLength(35)]
        public string LargeTraderID
        {
            get
            {
                return this._LargeTraderID;
            }
            set
            {
                this._LargeTraderID = value;
            }
        }


     
    }
}