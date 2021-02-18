<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/order/UpdateLogs.js此处编写
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
    import extend from "@/extension/order/UpdateLogs.js";
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
                    cnName: '版本更新',
                    name: 'UpdateLogs',
                    url: "/UpdateLogs/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFields: {"ProductCode":"","ProductName":"","Version":"","FilePath":"","Remark":""},
                editFormOptions: [[{"title":"代码","field":"ProductCode"},
                               {"title":"名称","field":"ProductName"}],
                              [{"title":"版本","field":"Version"},
                               {"title":"路径","field":"FilePath"}],
                              [{"title":"备注","field":"Remark","colSize":12,"type":"editor"}]],
                searchFormFields: {"ProductCode":"","ProductName":"","Version":"","Remark":"","Creator":"","CreateDate":""},
                searchFormOptions: [[{"title":"代码","field":"ProductCode"},{"title":"名称","field":"ProductName"},{"title":"版本","field":"Version"}],[{"title":"备注","field":"Remark"},{"title":"创建人","field":"Creator"},{"title":"创建时间","field":"CreateDate","type":"date"}]],
                columns: [{field:'Id',title:'Id',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'ProductCode',title:'代码',type:'string',width:90,align:'left',sortable:true},
                       {field:'ProductName',title:'名称',type:'string',width:90,align:'left'},
                       {field:'Version',title:'版本',type:'string',width:90,align:'left'},
                       {field:'FilePath',title:'路径',type:'file',width:90,align:'left'},
                       {field:'Remark',title:'备注',type:'string',width:90,align:'left'},
                       {field:'CreateID',title:'创建人ID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Creator',title:'创建人',type:'string',width:130,require:true,align:'left'},
                       {field:'CreateDate',title:'创建时间',type:'datetime',width:150,require:true,align:'left',sortable:true},
                       {field:'ModifyID',title:'ModifyID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Modifier',title:'Modifier',type:'string',width:130,hidden:true,align:'left'},
                       {field:'ModifyDate',title:'ModifyDate',type:'datetime',width:150,hidden:true,align:'left',sortable:true}],
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
