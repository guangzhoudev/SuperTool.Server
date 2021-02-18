<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/order/AppLog.js此处编写
 -->
<template>
    <div>
        <view-grid
                   ref="grid"
                   :columns="columns"
                   :detail="detail"
                   :editFormFields="editFormFields"
                   :editFormFileds="editFormFields"
                   :editFormOptions="editFormOptions"
                   :searchFormFields="searchFormFields"
                   :searchFormFileds="searchFormFields"
                   :searchFormOptions="searchFormOptions"
                   :table="table"
                   :extend="extend">
        </view-grid>
    </div>
</template>

<script>
    import extend from "@/extension/order/AppLog.js";
    import ViewGrid from "@/components/basic/ViewGrid.vue";
    var vueParam = {
        components: {
            ViewGrid
        },
        data() {
            return {
                table: {
                    key: 'Id',
                    footer: "Foots",
                    cnName: '应用日志',
                    name: 'AppLog',
                    url: "/AppLog/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFields: {"Account":"","ModuleName":"","Action":"","Remark":""},
                editFormOptions: [[{"title":"账号","field":"Account"},
                               {"title":"模块名称","field":"ModuleName"}],
                              [{"title":"行为","field":"Action"},
                               {"title":"描述","field":"Remark"}]],
                searchFormFields: {"Account":"","ModuleName":"","Action":"","Remark":""},
                searchFormOptions: [[{"title":"账号","field":"Account"},{"title":"模块名称","field":"ModuleName"}],[{"title":"行为","field":"Action"},{"title":"描述","field":"Remark"}]],
                columns: [{field:'Id',title:'Id',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Account',title:'账号',type:'string',width:120,align:'left',sortable:true},
                       {field:'ModuleName',title:'模块名称',type:'string',width:120,align:'left'},
                       {field:'Action',title:'行为',type:'string',width:120,align:'left'},
                       {field:'Remark',title:'描述',type:'string',width:120,align:'left'},
                       {field:'CreateDate',title:'创建时间',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'CreateID',title:'CreateID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Creator',title:'创建人',type:'string',width:130,align:'left'},
                       {field:'ModifyID',title:'ModifyID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Modifier',title:'Modifier',type:'string',width:130,hidden:true,align:'left'},
                       {field:'ModifyDate',title:'ModifyDate',type:'datetime',width:90,hidden:true,align:'left',sortable:true}],
                detail: {
                    cnName:"#detailCnName",
                    columns: [],
                    sortName: "",
                    key:""
                }
            };
        }
    };
    export default vueParam;
</script>
