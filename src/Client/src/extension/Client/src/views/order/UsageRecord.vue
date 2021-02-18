<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/order/UsageRecord.js此处编写
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
    import extend from "@/extension/order/UsageRecord.js";
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
                    cnName: '访问记录',
                    name: 'UsageRecord',
                    url: "/UsageRecord/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFields: {"Account":"","Name":"","UsageCount":""},
                editFormOptions: [[{"title":"账号","field":"Account"}],
                              [{"title":"模块名称","field":"Name"}],
                              [{"title":"使用次数","field":"UsageCount"}]],
                searchFormFields: {"Account":"","Name":"","UsageCount":""},
                searchFormOptions: [[{"title":"账号","field":"Account"},{"title":"模块名称","field":"Name"},{"title":"使用次数","field":"UsageCount"}]],
                columns: [{field:'Id',title:'Id',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Account',title:'账号',type:'string',width:120,align:'left',sortable:true},
                       {field:'Name',title:'模块名称',type:'string',width:120,align:'left'},
                       {field:'UsageCount',title:'使用次数',type:'string',width:120,align:'left'},
                       {field:'CreateDate',title:'创建时间',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'CreateID',title:'创建人ID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Creator',title:'创建人',type:'string',width:130,align:'left'},
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
