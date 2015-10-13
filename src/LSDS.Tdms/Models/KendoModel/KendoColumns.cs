using LSDS.Tdms.Models.Code;
using System;
using System.Collections.Generic;
using System.Linq;


namespace LSDS.Tdms.Models.KendoModel
{
    public class KendoColumns
    {
        public IEnumerable<KendoItem> KendoColumsSettings { get; set; }
        //public IEnumerable<KendoGridModel> KendoModelSettings { get; set; }
        private static string ReturmEmptyIfNull(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? "" : value;
        }

        private static string ReturnSummaryType(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return "";
            return value.ToLower().Equals("avg") ? "average" : value.ToLower();
        }

        private static string ReturnSummaryTypeFooter(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return "";
            return value.ToLower().Equals("avg") ? "#= average #" : "#= " + value.ToLower() + " #";
        }

        public IEnumerable<KendoItem> ReturnKendoColumSettings(string userName, string source)
        {
            try
            {
                var getTableDetail = new GetTableDetail();
                var tableDetail = getTableDetail.ReturnTableDetailData(source, userName);
                var kendoColumns = new KendoColumns();

                var newTempListAggregate = tableDetail.Select(value => new KendoItem
                {
                    aggregate = new KendoGridAggregates
                    {
                        field = ReturmEmptyIfNull(value.Column_Name),
                        aggregate = ReturnSummaryType(value.SummaryType)
                    }
                }).ToList();
                var kendoColumnsAgre =
                    newTempListAggregate.Select(item => item.aggregate).Where(item => item.aggregate.Length > 1);

                var newTempList = tableDetail.Select(value => new KendoItem
                {
                    field = value.Column_Name,
                    title = value.Column_Header,
                    width = value.Column_Width.HasValue ? value.Column_Width.ToString() + "px" : "130px",
                    height = "20px",
                    format = value.FormatString ?? "",
                    template =
                        "#= Format(" + value.Column_Name + ",'" + value.Datatype + "','" + value.FormatString + "','" +
                        value.LinkCommand + "','" + value.IsCheckbox + "') #",
                    model = new KendoGridModel
                    {
                        fields = value.Column_Name,
                        type = new KendoGridType {type = converDataType(value.Datatype)}
                    },
                    attributes = new KendoGridAttributes
                    {
                        style = "#= ColorAttribute(" + value.Column_Name + ",'" + value.ColorControl + "') #"
                    },
                    aggregateList = kendoColumnsAgre,
                    footerTemplate = ReturnSummaryTypeFooter(value.SummaryType)
                }).ToList();

                //newTempListAggregate = tableDetail.Select(value => new KendoItem
                //{
                //    aggregate = new KendoGridAggregates()
                //    {
                //        field = value.Column_Name,
                //        aggregate = value.SummaryType
                //    }

                //}).ToList();

                kendoColumns.KendoColumsSettings = newTempList;
                return kendoColumns.KendoColumsSettings;
            }
            catch (System.Exception ex)
            {
               // FormsAuthentication.SignOut();
                return null;
            }
        }

        public string converDataType(string dataType)
        {
            switch (dataType.ToLower())
            {
                case "date":
                    dataType = "date";
                    break;
                case "dec":
                case "int":
                    dataType = "number";
                    break;
                default:
                    dataType = "string";
                    break;
            }
            return dataType;
        }
    }
}