<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/order/WorkOrder.js此处编写
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
    import extend from "@/extension/order/WorkOrder.js";
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
                    cnName: '工单管理',
                    name: 'WorkOrder',
                    url: "/WorkOrder/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFields: {"Title":"","Contents":"","Type":"","Account":"","Status":"","Remark":""},
                editFormOptions: [[{"title":"标题","field":"Title"},
                               {"title":"内容","field":"Contents"},
                               {"dataKey":"status","data":[],"title":"类别","field":"Type"}],
                              [{"title":"提交人账号","field":"Account"},
                               {"title":"状态","field":"Status"},
                               {"title":"备注","field":"Remark"}]],
                searchFormFields: {"Title":"","Contents":"","Type":"","Account":"","Status":"","CreateDate":""},
                searchFormOptions: [[{"title":"标题","field":"Title"},{"title":"内容","field":"Contents"},{"dataKey":"status","data":[],"title":"类别","field":"Type"}],[{"title":"提交人账号","field":"Account"},{"title":"状态","field":"Status"},{"title":"创建日期","field":"CreateDate","type":"date"}]],
                columns: [{field:'Id',title:'Id',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Title',title:'标题',type:'string',width:120,align:'left',sortable:true},
                       {field:'Contents',title:'内容',type:'string',width:120,align:'left'},
                       {field:'Type',title:'类别',type:'string',bind:{ key:'status',data:[]},width:120,align:'left'},
                       {field:'Account',title:'提交人账号',type:'string',width:120,align:'left'},
                       {field:'Status',title:'状态',type:'string',width:120,align:'left'},
                       {field:'Remark',title:'备注',type:'string',width:120,align:'left'},
                       {field:'CreateID',title:'创建人ID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Creator',title:'创建人',type:'string',width:130,align:'left'},
                       {field:'CreateDate',title:'创建日期',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'ModifyID',title:'编辑人ID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Modifier',title:'编辑人',type:'string',width:130,hidden:true,align:'left'},
                       {field:'ModifyDate',title:'编辑时间',type:'datetime',width:90,hidden:true,align:'left',sortable:true}],
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
