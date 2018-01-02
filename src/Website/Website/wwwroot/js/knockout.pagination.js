﻿var viewmodel = {
    rows: ko.observableArray([]),
    total: ko.observable(0),
    pageSize: ko.observable(10),
    pageIndex: ko.observable(1),
    pageCount: ko.observable(0),
    pageNumbers: ko.observableArray(),
    targetPageIndex: ko.observable(1),
    remoteUrl: ko.observable(''),
    coursewareId: ko.observable(''),
    next: function () {
        if (this.pageIndex() < this.pageCount()) {
            this.pageIndex(this.pageIndex() + 1);
            loadList(this.remoteUrl(),
                {
                    pageSize: this.pageSize(),
                    pageIndex: this.pageIndex(),
                    coursewareId: this.coursewareId()
                });
        } else {
            layer.msg("已经是最后一页了");
        }
    },
    previous: function () {
        if (this.pageIndex() > 1) {
            this.pageIndex(this.pageIndex() - 1);
            loadList(this.remoteUrl(),
                {
                    pageSize: this.pageSize(),
                    pageIndex: this.pageIndex(),
                    coursewareId: this.coursewareId()
                });
        } else {
            layer.msg("已经是第一页了");
        }
    },
    gotopage: function (data, event) {
        if (data > this.pageCount() || data < 0) {
            layer.msg("您输入的页码超出范围了，无法为您完成跳转。");
        } else {
            this.pageIndex(data);
            loadList(this.remoteUrl(),
                {
                    pageSize: this.pageSize(),
                    pageIndex: this.pageIndex(),
                    coursewareId: this.coursewareId()
                });            
        }
    },
    checkExistedData: function() {
        return this.total() > 0;
    },
    checkShowPagination: function() {
        return this.pageCount() > 1;
    },
    isFirst:function(){
        return this.pageIndex()==1;
    },
    isLast:function(){
        return this.pageIndex()==this.pageCount();
    }
};
ko.applyBindings(viewmodel);

function loadList(url, data) {
    $.get(url,
        data,
        function (data) {
            viewmodel.pageNumbers.removeAll();
            ko.mapping.fromJS(data, {}, viewmodel);
            for (var i = 0; i < data.pageCount; i++) {
                viewmodel.pageNumbers.push(i + 1);
            }
        });
}