


var sAll = 'All';
var sSelected = 'Selected';


function SetMultiSelector(eleSelectorString, eWidth,eMaxHeight,eFirstCheckAll)
{
    $(eleSelectorString).dropdownchecklist(
      {
          width: eWidth,
          maxDropHeight: eMaxHeight,
          firstItemChecksAll: eFirstCheckAll,         

          textFormatFunction: function (options) {
              var selectedOptions = options.filter(":selected");
              var countOfSelected = selectedOptions.size();
              var size = options.size();
              switch (countOfSelected) {
                  case 0: return "";
                  case 1: return selectedOptions.text();
                  case size: return sAll;
                  default: return countOfSelected + ' ' + sSelected;
              }
          },
          icon: {
              placement: 'right',
              toOpen: 'ui-dropdown-iconopen',
              toClose: 'ui-dropdown-iconclose'
          }
      }
    );
  }
