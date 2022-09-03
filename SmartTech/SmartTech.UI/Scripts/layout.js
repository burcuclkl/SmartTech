$(document).ready(function () {

    //Method Call(s)
    LoadCategories();
    LoadBrands();


    //Method Body(s)
    function LoadCategories() {

        CallAjax('/Ajax/CategoryList', '').success(function (response) {
            var lstCategories = $('#lstCategories');
            for (var i = 0; i < response.length; i++) {
                var liOpen = '<li>';
                var aOpen = '<a href="/Default/CategoryProducts?catId=' + response[i].Id + '">';
                var name = response[i].Name;
                var aClose = '</a>';
                var liClose = '</li>';

                var appendText = liOpen + aOpen + name + aClose + liClose;
                lstCategories.append(appendText);
            }
            CloseBlock();
        });

    }
    function LoadBrands() {

        CallAjax('/Ajax/BrandList', '').success(function (response) {
            var selectBrandList = $('#selectBrandList');
            for (var i = 0; i < response.length; i++) {

                var optionOpen = '<option>';
                var name = response[i].Name;
                var optionClose = '</option>';

                var appendText = optionOpen + name + optionClose;

                selectBrandList.append(appendText);
            }
            CloseBlock();
        });

    }
});