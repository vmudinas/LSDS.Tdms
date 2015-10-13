$(document).ready(function () {
    //Ensure JSON is loaded
    if (typeof JSON == 'undefined') {
        $.getScript('javascript/json2.js', function () {});
    }
});


    $.fn.TDMSReferenceData = function (options) {

 // if(ReturnUserPermission(options.ReferenceEntity) != "None"){
        var settings = {
            'ReferenceEntity': 'Portfolio',
            'Title': 'Portfolio Profile',
            'reload': 'false',
            'height': 500,
            'width': 820
        };

        var webServiceLookup = {
            "Portfolio":
                            {
                                "url": "/TDMSReferenceData.asmx/PortfolioProfileReferenceJSon",
                                "parameterName": "portfolioId",
                                "templateFile": "Templates/PortfolioProfile.htm?v=9",
                                "scriptFile": "javascript/PortfolioRef.js",
                                "scriptObject": "portfolioRefData",
                                "baseDBTable": "tblShawPort"
                            },
            "Broker":
                            {
                                "url": "/TDMSReferenceData.asmx/BrokerProfileReferenceJSon",
                                "parameterName": "brokerCode",
                                "templateFile": "Templates/BrokerProfile.htm",
                                "scriptFile": "javascript/BrokerRef.js",
                                "scriptObject": "brokerRefData",
                                "baseDBTable": "tblBrokerInfo"
                            }
        };


        return this.each(function () {
          

            if (options) {
                $.extend(settings, options);
            }

            $(this).css('text-decoration', 'underline')
                .css('cursor', 'pointer')
                .unbind('click')
                .data('options',options)
                .click(function () { DisplayDataReference(this); });
        });

   //     }

        function DisplayDataReference(sender) {
            //Remove/add template container
            var reload = false;
            if ($('#referenceDataContainer').data('ReferenceEntity') == settings.ReferenceEntity) {
                reload = true;
            }

            if (reload == false) {
               $('#referenceDataContainer').remove();
                //Build a template container
                $(document.body).append(
                    $(document.createElement('div'))
                    .addClass('referenceDataContainer')
                    .attr('id', 'referenceDataContainer')
                    .data('ReferenceEntity', settings.ReferenceEntity)
                    .css('background-color', '#FFFFFF')
                    .css('border', '1px solid #004488')
                    .css('height', settings.height + 'px')
                    .css('width', settings.width + 'px')
                    .css('top', (($(window).height() - settings.height) / 2) + $(window).scrollTop() + 'px')
                    .css('left',($(window).width() - settings.width) / 2 + 'px')
                    .css('z-index', '99999999')
                    .draggable({ handle: '.referenceDataHeader', containment: 'document' })
                    .css('position','absolute')
                    .hide()
                    .append(
                        $(document.createElement('div'))
                        .attr('id','referenceDataX')
                        .addClass('xOut')
                        .mouseover(function () { this.className = 'xOutOver'; })
                        .mouseout(function () { this.className = 'xOut'; })
                        .click(function () {
                            
                            eval(webServiceLookup[settings.ReferenceEntity].scriptObject + '.ClearDataObject();');

                            $('#referenceDataContainer').hide('slow'); 
                         })
                        .text('x')
                        )
                        .append(
                            $(document.createElement('div'))
                            .addClass('referenceDataHeader')
                            .text(settings.Title)
                            .css('cursor', 'move')
                        )
                    .append(
                        $(document.createElement('div'))
                        .addClass('referenceDataContent')
                        .addClass('referenceDataContent')
                            .append(
                                $(document.createElement('div'))
                                .addClass('referenceDataLoadingContainer')
                                .css('width', '100%')
                                .css('height', '430px')
                                .css('text-align', 'center')
                                    .append(
                                        $(document.createElement('img'))
                                        .attr('src', 'images/loading_large.gif')
                                        .addClass('referenceDataLoading')
                                        .css('width', '100px')
                                        .css('height', '100px')
                                        .css('margin-top', '160px')
                                        )
                                )
                        )
                    );

            }
            else {
                $('.referenceDataContent').children().remove();
                $('.referenceDataContent')
        .append(
            $(document.createElement('div'))
            .addClass('referenceDataLoadingContainer')
            .css('width', '100%')
            .css('height', '430px')
            .css('text-align', 'center')
                .append(
                    $(document.createElement('img'))
                    .attr('src', 'images/loading_large.gif')
                    .addClass('referenceDataLoading')
                    .css('width', '100px')
                    .css('height', '100px')
                    .css('margin-top', '160px')
                    )
            );
            }

          //  if(settings.ReferenceEntity.toString() === 'Portfolio No.') 
         //   {
            //    alert(settings.ReferenceEntity);// = 'Portfolio';
           // } 

            var ajaxUrl = webServiceLookup[settings.ReferenceEntity].url;
            var ajaxData = '';

            switch ($(sender).get(0).tagName.toLowerCase()) {
                case 'input':
                    ajaxData = '{' + webServiceLookup[settings.ReferenceEntity].parameterName + ':"' + $(sender).val() + '"}';
                    break;

                case 'td':
                    ajaxData = '{' + webServiceLookup[settings.ReferenceEntity].parameterName + ':"' + $.trim($(sender).text()) + '"}';
                    break;

                default:
                    ajaxData = '{' + webServiceLookup[settings.ReferenceEntity].parameterName + ':"' + $(sender).val() + '"}';
                    break;
            }

            $.ajax({
                type: "POST",
                xhr: (window.ActiveXObject) ?
		        function () {
		            try {
		                return new window.ActiveXObject("Microsoft.XMLHTTP");
		            } catch (e) { }
		        } :
			        function () {
			            return new window.XMLHttpRequest();
			        },
                url: ajaxUrl + "?" + new Date().getTime(),
                data: ajaxData,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (msg) {
                    //Retrieve JSON object - find it in 'd' and remove brackets
                    var jSonData = $.parseJSON(msg.d);

                    if (jSonData[webServiceLookup[settings.ReferenceEntity].baseDBTable].length > 0) {
                    
                        //Call the template from file
                        $.get(webServiceLookup[settings.ReferenceEntity].templateFile, function (template) {
                            $.tmpl(template, jSonData).appendTo(".referenceDataContent");
                            $('.referenceDataLoadingContainer').remove();
                            $('#referenceDataContainer').show();
                            $('.referenceDataUpdateBar').css('width',(settings.width - 40) + 'px');
                            $.getScript(webServiceLookup[settings.ReferenceEntity].scriptFile + '?' + ReturnGuid(), function () {
                                //Send the data to the script object:
                                setTimeout(function () { eval(webServiceLookup[settings.ReferenceEntity].scriptObject + '.SetDataObject(jSonData);' + webServiceLookup[settings.ReferenceEntity].scriptObject + '.SetSenderElement(sender);' + webServiceLookup[settings.ReferenceEntity].scriptObject + '.Initialize();'); }, 500);

                            });
                        });
                    }
                    else {
                        alert('Unknown ' + settings.ReferenceEntity + ' item.');
                    }
                }
            });
        }
    };

    ReturnGuid = function () {
        return new Date().getTime() + "_" + Math.round(Math.random() * 100000000);
    };

    var xhttp;
    ReturnUserPermission = function (itemName) {
        var item_name = '';
        xhttp = new XMLHttpRequest();
        if (itemName == 'Portfolio')
            item_name = 'TDMSPortfolioDetail';
        else if (itemName == 'Broker')
            item_name = 'TDMSBrokerDetail';

        var theData = "itemName=" + item_name;
        var result = false;

        xhttp.open("POST", "/TDMSReferenceData.asmx/ReturnUserPermission", false);
        xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
        xhttp.send(theData);

        if (xhttp.status == 200) {
            if (xhttp.readyState == 4) {
                var nodes = xhttp.responseXML.getElementsByTagName("string");
                result = ReturnXMLNodeContent(nodes, 0);
            }
        }
        return result;
    };

