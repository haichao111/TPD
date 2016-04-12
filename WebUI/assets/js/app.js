// ajax

$.ajaxSetup({ cache: false });
var ajaxErrorMessage = "操作出现异常！";

$(function () {

	// ajax modal
	$(document).on('click.bs.modal.data-api', '[data-toggle="ajax-modal"]', function (event) {

		var $this = $(this),
			url = $this.data('url'),
			$target = $($this.data('target'));

		$.get(url, function (response) {
			// ajax get form content
			$target
				.html(response)
				.modal('show')
				.find('.form-control').first().focus();
		});

	});


});


// viewModel

function findInViewModel(key, value, fn, list) {
	list = list || viewModel.dataList;
	$.each(list(), function (k, d) {
		if (d[key] == value) {
			fn(d, k, list); // data, index, list
			return false;
		}
	});
}

// Date format

String.prototype.toDate = function() {
	return new Date(parseInt(this.replace(/[^\d]/igm, '')))
}

Date.prototype.formatNoMoment = function (format) {
	/* 
	 * eg:format="yyyy-MM-dd hh:mm:ss"; 
	 */
	var o = {
		"M+": this.getMonth() + 1, // month  
		"d+": this.getDate(), // day  
		"h+": this.getHours(), // hour  
		"m+": this.getMinutes(), // minute  
		"s+": this.getSeconds(), // second  
		"q+": Math.floor((this.getMonth() + 3) / 3), // quarter  
		"S": this.getMilliseconds()
		// millisecond  
	};

	if (/(y+)/.test(format)) {
		format = format.replace(RegExp.$1, (this.getFullYear() + "").substr(4
							 - RegExp.$1.length));
	}

	for (var k in o) {
		if (new RegExp("(" + k + ")").test(format)) {
			format = format.replace(RegExp.$1, RegExp.$1.length == 1
								 ? o[k]
								 : ("00" + o[k]).substr(("" + o[k]).length));
		}
	}
	return format;
};


// get json from from

function formJson(form) {
	var o = {};
	$.each($(form).serializeArray(), function (d, k) {
		if (o[this.name]) {
			if (!o[this.name].push) { o[this.name] = [o[this.name]]; }
			o[this.name].push(this.value || '');
		} else {
			o[this.name] = this.value || '';
		}
	});
	return o;
}


// boot-grid

var gridOptions = {

	ajax: true,

	padding: 4,

	rowCount: [10, 20, 50, -1],

	labels: {
		all: "全部",
		infos: "显示 {{ctx.start}} 到 {{ctx.end}} 共 {{ctx.total}} 记录",
		loading: "数据加载中...",
		noResults: "无可寻记录",
		refresh: "重新加载",
		search: "搜索"
	},

	css: {
		icon: "icon_n glyphicon",
	},

	templates: {
		footer: "<div id=\"{{ctx.id}}\" class=\"{{css.footer}}\"><div class=\"row infoBar\"><p class=\"{{css.pagination}}\"></p><p class=\"{{css.infos}}\"></p></div></div>"
	},

	formatters: {

		"Boolean": function (column, row) { return row[column.id] ? "<i class=\"fa fa-check-square-o fa-lg\"></i>" : ""; },

		"Current": function (column, row) { return "$" + row[column.id]; },

		"DateTime": function (column, row) { return row[column.id].toDate().formatNoMoment('yyyy-MM-dd hh:mm:ss'); },

		"DateOnly": function (column, row) { return row[column.id].toDate().formatNoMoment('yyyy-MM-dd'); },

		"Email": function (column, row) { return "<a href='mailto:" + row[column.id] + "'>" + row[column.id] + "</a>"; },

		"Percent": function (column, row) { return row[column.id] + " %"; },

		"TimeOnly": function (column, row) { return row[column.id]; },

		"Url": function (column, row) {
			var text = row[column.id], url = text;
			if (!(typeof text === "string")) { url = text.url; text = text.text; }
			return "<a href='" + url + "'>" + text + "</a>";
		},

	},

	responseHandler: function (response) {
		if (response.errMessage) {
			alert(response.errMessage);
			return { current: 1, rowCount: 10, rows: [], total: 0 };
		}
		else {
			return response;
		}
	},

	loadDataErrorHandler: function (errMessage) {
		alert(errMessage);
	}

};


// summer-edit upload file

function sendFile(file, editor, welEditable) {
	data = new FormData();
	data.append("file", file);
	$.ajax({
		data: data,
		type: "POST",
		url: "/Attachment/General",
		cache: false,
		contentType: false,
		processData: false,
		success: function (data) {
			editor.insertImage(welEditable, data.showPath);
		}
	});
}

// date range picker

var dateRangeOption = {
	"autoApply": true,
	"locale": {
		"format": "YYYY-MM-DD",
		"separator": " 至 ",
		"applyLabel": "Apply",
		"cancelLabel": "Cancel",
		"fromLabel": "From",
		"toLabel": "To",
		"customRangeLabel": "Custom",
		"daysOfWeek": [ "日", "一", "二", "三", "四", "五", "六" ],
		"monthNames": [ "一月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "十一月", "十二月" ],
		"firstDay": 1
	}
}