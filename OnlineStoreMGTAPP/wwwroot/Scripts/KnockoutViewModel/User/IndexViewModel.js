function IndexViewModel() {
    var self = this;
    self.UserDetailGrid = ko.observableArray([]);
    self.TotolCount = ko.observable(0);
    self.TotalItemCount = ko.observable(0);
    self.searchText = ko.observable("");
   
    
    $(function () {
        $.ajax({
            url: '/User/GetDataForIndex',
            cache: false,
            type: 'POST',
            dataType: 'json',
            contentType: 'application/json',
            success: function (data) {
                ko.mapping.fromJS(data.userDetails, {}, self.UserDetailGrid);
                self.TotalItemCount(data.totalCount);
                self.Pager().CurrentPage(1);
            },
            error: function (data) {    
                alert('Error while getting records- ' + data);
            }
        });
      
    });

   

    self.SearchUser = function () {
        if (self.searchText() === '') {
            alertify.alert("Please enter something");
            return false;
        }
        else
        {
            $.post("/User/GetUserByUserName", {
                searchtext: self.searchText()
            }, function (_data) {
                self.UserDetailGrid.removeAll();
                ko.mapping.fromJS(_data.userDetails, {}, self.UserDetailGrid);
                self.TotalItemCount(_data.totalCount);
            });
        }
      
    };

    var pagingSettings = {
        pageSize: 10,
        pageSlide: 2
    };
    self.Skip = ko.observable(0);
    self.Take = ko.observable(pagingSettings.pageSize);
    self.Pager = ko.pager(self.TotalItemCount);
    self.Pager().PageSize(pagingSettings.pageSize);
    self.Pager().PageSlide(pagingSettings.pageSlide);
    self.Pager().CurrentPage(1);
    self.Pager().CurrentPage.subscribe(function () {
        var skip = pagingSettings.pageSize * (self.Pager().CurrentPage() - 1);
        var take = pagingSettings.pageSize;
        $('#loaderDiv').show();
        self.GetRecordsWithSkipTake(skip, take);
    });
    self.GetRecordsWithSkipTake = function (skip, take) {
        if (skip === undefined || take === undefined) {
            self.Skip(0);
            self.Take(pagingSettings.pageSize);
        }
        else {
            self.Skip(skip);
            self.Take(take);
        }
        RebindAndPaggging(skip);
        $('#loaderDiv').hide();
    };
    function RebindAndPaggging(skip) {
        if (self.searchText() !== "") {
            $.post("/User/GetUserByUserName", {
                skip: skip,
                searchtext: self.searchText()
            }, function (_data) {
                self.UserDetailGrid.removeAll();
                ko.mapping.fromJS(_data.userDetails, {}, self.UserDetailGrid);
                self.TotalItemCount(_data.totalCount);
            });
        }
        else {
            $.post("/User/GetPagedUserData", {
                skip: skip
            }, function (_data) {
                self.UserDetailGrid.removeAll();
                ko.mapping.fromJS(_data.userDetails, {}, self.UserDetailGrid);
                self.TotalItemCount(_data.totalCount);
            });
        }
    }
}

ko.applyBindings(new IndexViewModel);


