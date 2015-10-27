using System.ComponentModel.DataAnnotations;

namespace LSDS.CTM.CtmMessages
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CTM_TradeDetailBodyTradeLevelInformation
    {
        [Key]
        [System.Xml.Serialization.XmlIgnore]
        public int CtmId { get; set; }

        private string typeOfTransactionIndicatorField;
        private string buySellIndicatorField;
        private string typeOfFinancialInstrumentField;
        private ulong tradeDateTimeField;
        private uint settlementDateField;
        private string typeOfPriceIndicator;
        private string placeOfClearing;
        private string bestExecution;
        private string lotSize;
        private string listed;
        private string issuer;
        private string tradeTransactionConditionIndicator;
        private string bookEntry;
        private string iPOFlag;
        private int numberOfDaysAccrued;
        private int maturityDate;
        private int callDate;
        private string callType;
        private int datedDate;
        private string currentFaceValue;
        private string poolNumber;
        private string whenIssue;
        private int issueDate;
        private string alternativeMinimumTax;
        private string federalTax;
        private int factorEffectiveDate;
        private int recordDate;
        private string partyCapacityIndicator;
        private string oMNIExpected;



        private CTM_TradeDetailBodyTradeLevelInformationDealPrice dealPriceField;
        private CTM_TradeDetailBodyTradeLevelInformationQuantityOfTheBlockTrade quantityOfTheBlockTradeField;
        private CTM_TradeDetailBodyTradeLevelInformationTotalTradeAmount totalTradeAmountField;   
        private CTM_TradeDetailBodyTradeLevelInformationTimeZone timeZoneField;
        private CTM_TradeDetailBodyTradeLevelInformationPlaceOfTrade placeOfTrade;
        private CTM_TradeDetailBodyTradeLevelInformationWhereListed whereListed;
        private CTM_TradeDetailBodyTradeLevelInformationYield yield;
        private CTM_TradeDetailBodyTradeLevelInformationCouponRate couponRate;
        private CTM_TradeDetailBodyTradeLevelInformationCallPrice callPrice;
        private CTM_TradeDetailBodyTradeLevelInformationCurrentFactor currentFactor;
        private CTM_TradeDetailBodyTradeLevelInformationRating rating;
        private CTM_TradeDetailBodyTradeLevelInformationAdditionalMunicipalDebtData additionalMunicipalDebtData;
        private CTM_TradeDetailBodyTradeLevelInformationStipulationsStandard stipulationsStandard;
        private CTM_TradeDetailBodyTradeLevelInformationStipulationsNonStandard stipulationsNonStandard;


        [MaxLength(4)]
        public string PartyCapacityIndicator
        {
            get
            {
                return this.partyCapacityIndicator;
            }
            set
            {
                this.partyCapacityIndicator = value;
            }
        }
        [MaxLength(1)]
        public string OMNIExpected
        {
            get
            {
                return this.oMNIExpected;
            }
            set
            {
                this.oMNIExpected = value;
            }
        }



        public CTM_TradeDetailBodyTradeLevelInformationStipulationsNonStandard StipulationsNonStandard
        {
            get
            {
                return this.stipulationsNonStandard;
            }
            set
            {
                this.stipulationsNonStandard = value;
            }
        }


        public CTM_TradeDetailBodyTradeLevelInformationStipulationsStandard StipulationsStandard
        {
            get
            {
                return this.stipulationsStandard;
            }
            set
            {
                this.stipulationsStandard = value;
            }
        }

        public CTM_TradeDetailBodyTradeLevelInformationAdditionalMunicipalDebtData AdditionalMunicipalDebtData
        {
            get
            {
                return this.additionalMunicipalDebtData;
            }
            set
            {
                this.additionalMunicipalDebtData = value;
            }
        }
       
        //public int FactorEffectiveDate
        //{
        //    get
        //    {
        //        return this.factorEffectiveDate;
        //    }
        //    set
        //    {
        //        this.factorEffectiveDate = value;
        //    }
        //}
       
        //public int RecordDate
        //{
        //    get
        //    {
        //        return this.recordDate;
        //    }
        //    set
        //    {
        //        this.recordDate = value;
        //    }
        //}

        public CTM_TradeDetailBodyTradeLevelInformationRating Rating
        {
            get
            {
                return this.rating;
            }
            set
            {
                this.rating = value;
            }
        }
        [MaxLength(4)]
        public string AlternativeMinimumTax
        {
            get
            {
                return this.alternativeMinimumTax;
            }
            set
            {
                this.alternativeMinimumTax = value;
            }
        }

        [MaxLength(4)]
        public string FederalTax
        {
            get
            {
                return this.federalTax;
            }
            set
            {
                this.federalTax = value;
            }
        }

      
        //public int IssueDate
        //{
        //    get
        //    {
        //        return this.issueDate;
        //    }
        //    set
        //    {
        //        this.issueDate = value;
        //    }
        //}

        [MaxLength(4)]
        public string WhenIssue
        {
            get
            {
                return this.whenIssue;
            }
            set
            {
                this.whenIssue = value;
            }
        }

        [MaxLength(30)]
        public string PoolNumber
        {
            get
            {
                return this.poolNumber;
            }
            set
            {
                this.poolNumber = value;
            }
        }

        [MaxLength(17)]
        public string CurrentFaceValue
        {
            get
            {
                return this.currentFaceValue;
            }
            set
            {
                this.currentFaceValue = value;
            }
        }

        public CTM_TradeDetailBodyTradeLevelInformationCurrentFactor CurrentFactor
        {
            get
            {
                return this.currentFactor;
            }
            set
            {
                this.currentFactor = value;
            }
        }

        [MaxLength(35)]
        public string CallType
        {
            get
            {
                return this.callType;
            }
            set
            {
                this.callType = value;
            }
        }
        //public int DatedDate
        //{
        //    get
        //    {
        //        return this.datedDate;
        //    }
        //    set
        //    {
        //        this.datedDate = value;
        //    }
        //}

        public CTM_TradeDetailBodyTradeLevelInformationCallPrice CallPrice
        {
            get
            {
                return this.callPrice;
            }
            set
            {
                this.callPrice = value;
            }
        }

        public CTM_TradeDetailBodyTradeLevelInformationCouponRate CouponRate
        {
            get
            {
                return this.couponRate;
            }
            set
            {
                this.couponRate = value;
            }
        }

        public CTM_TradeDetailBodyTradeLevelInformationYield Yield
        {
            get
            {
                return this.yield;
            }
            set
            {
                this.yield = value;
            }
        }

        //public int MaturityDate
        //{
        //    get
        //    {
        //        return this.maturityDate;
        //    }
        //    set
        //    {
        //        this.maturityDate = value;
        //    }
        //}
        //public int CallDate
        //{
        //    get
        //    {
        //        return this.callDate;
        //    }
        //    set
        //    {
        //        this.callDate = value;
        //    }
        //}

        //public int NumberOfDaysAccrued
        //{
        //    get
        //    {
        //        return this.numberOfDaysAccrued;
        //    }
        //    set
        //    {
        //        this.numberOfDaysAccrued = value;
        //    }
        //} 
        [MaxLength(4)]
        public string IPOFlag
        {
            get
            {
                return this.iPOFlag;
            }
            set
            {
                this.iPOFlag = value;
            }
        }
        [MaxLength(4)]
        public string BookEntry
        {
            get
            {
                return this.bookEntry;
            }
            set
            {
                this.bookEntry = value;
            }
        }
        [MaxLength(4)]
        public string TradeTransactionConditionIndicator
        {
            get
            {
                return this.tradeTransactionConditionIndicator;
            }
            set
            {
                this.tradeTransactionConditionIndicator = value;
            }
        }

        [MaxLength(35)]
        public string Issuer
        {
            get
            {
                return this.issuer;
            }
            set
            {
                this.issuer = value;
            }
        }
        [MaxLength(1)]
        public string Listed
        {
            get
            {
                return this.listed;
            }
            set
            {
                this.listed = value;
            }
        }
        public CTM_TradeDetailBodyTradeLevelInformationPlaceOfTrade PlaceOfTrade
        {
            get
            {
                return this.placeOfTrade;
            }
            set
            {
                this.placeOfTrade = value;
            }
        }
        [MaxLength(8)]
        public string PlaceOfClearing
        {
            get
            {
                return this.placeOfClearing;
            }
            set
            {
                this.placeOfClearing = value;
            }
        }
        [MaxLength(15)]
        public string LotSize
        {
            get
            {
                return this.lotSize;
            }
            set
            {
                this.lotSize = value;
            }
        }
        [MaxLength(4)]
        public string BestExecution
        {
            get
            {
                return this.bestExecution;
            }
            set
            {
                this.bestExecution = value;
            }
        }
        /// <remarks/>
        [MaxLength(4)]
        public string TypeOfTransactionIndicator
        {
            get
            {
                return this.typeOfTransactionIndicatorField;
            }
            set
            {
                this.typeOfTransactionIndicatorField = value;
            }
        }
        [MaxLength(4)]
        public string TypeOfPriceIndicator
        {
            get
            {
                return this.typeOfPriceIndicator;
            }
            set
            {
                this.typeOfPriceIndicator = value;
            }
        }

        /// <remarks/>
        [MaxLength(4)]  public string BuySellIndicator
        {
            get
            {
                return this.buySellIndicatorField;
            }
            set
            {
                this.buySellIndicatorField = value;
            }
        }

        /// <remarks/>
         [MaxLength(4)] public string TypeOfFinancialInstrument
        {
            get
            {
                return this.typeOfFinancialInstrumentField;
            }
            set
            {
                this.typeOfFinancialInstrumentField = value;
            }
        }

        /// <remarks/>
        public CTM_TradeDetailBodyTradeLevelInformationDealPrice DealPrice
        {
            get
            {
                return this.dealPriceField;
            }
            set
            {
                this.dealPriceField = value;
            }
        }

        /// <remarks/>
        public CTM_TradeDetailBodyTradeLevelInformationQuantityOfTheBlockTrade QuantityOfTheBlockTrade
        {
            get
            {
                return this.quantityOfTheBlockTradeField;
            }
            set
            {
                this.quantityOfTheBlockTradeField = value;
            }
        }

        /// <remarks/>
        public CTM_TradeDetailBodyTradeLevelInformationTotalTradeAmount TotalTradeAmount
        {
            get
            {
                return this.totalTradeAmountField;
            }
            set
            {
                this.totalTradeAmountField = value;
            }
        }

        /// <remarks/>
        public ulong TradeDateTime
        {
            get
            {
                return this.tradeDateTimeField;
            }
            set
            {
                this.tradeDateTimeField = value;
            }
        }

        /// <remarks/>
        public CTM_TradeDetailBodyTradeLevelInformationTimeZone TimeZone
        {
            get
            {
                return this.timeZoneField;
            }
            set
            {
                this.timeZoneField = value;
            }
        }

        /// <remarks/>
        public uint SettlementDate
        {
            get
            {
                return this.settlementDateField;
            }
            set
            {
                this.settlementDateField = value;
            }
        }
    }
}