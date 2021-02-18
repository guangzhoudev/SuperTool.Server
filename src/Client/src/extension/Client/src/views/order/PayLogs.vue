<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/order/PayLogs.js此处编写
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
    import extend from "@/extension/order/PayLogs.js";
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
                    cnName: '支付记录',
                    name: 'PayLogs',
                    url: "/PayLogs/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFields: {"Account":"","Tel":"","Money":"","Agent":"","PayWay":"","PayTime":"","Remark":"","PayStatus":""},
                editFormOptions: [[{"title":"账号","field":"Account"},
                               {"title":"电话","field":"Tel"}],
                              [{"title":"代理商","field":"Agent"},
                               {"title":"金额","required":true,"field":"Money","type":"decimal"}],
                              [{"title":"交易方式","field":"PayWay"},
                               {"title":"交易时间","required":true,"field":"PayTime","type":"date"}],
                              [{"title":"备注","field":"Remark"},
                               {"title":"交易状态","field":"PayStatus"}]],
                searchFormFields: {"Account":"","Tel":"","Money":"","Agent":"","PayWay":"","PayTime":""},
                searchFormOptions: [[{"title":"账号","field":"Account"},{"title":"电话","field":"Tel"},{"title":"金额","field":"Money","type":"decimal"}],[{"title":"代理商","field":"Agent"},{"title":"交易方式","field":"PayWay"},{"title":"交易时间","field":"PayTime","type":"date"}]],
                columns: [{field:'Id',title:'Id',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Account',title:'账号',type:'string',width:90,align:'left',sortable:true},
                       {field:'Tel',title:'电话',type:'string',width:90,align:'left'},
                       {field:'Money',title:'金额',type:'float',width:90,require:true,align:'left'},
                       {field:'Agent',title:'代理商',type:'string',width:90,align:'left'},
                       {field:'PayWay',title:'交易方式',type:'string',width:90,align:'left'},
                       {field:'PayTime',title:'交易时间',type:'string ',width:90,require:true,align:'left'},
                       {field:'Remark',title:'备注',type:'string',width:90,align:'left'},
                       {field:'PayStatus',title:'交易状态',type:'string',width:90,align:'left'},
                       {field:'CreateID',title:'CreateID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'CreateDate',title:'创建时间',type:'datetime',width:150,hidden:true,align:'left',sortable:true},
                       {field:'Creator',title:'创建人',type:'string',width:130,hidden:true,align:'left'},
                       {field:'ModifyDate',title:'ModifyDate',type:'datetime',width:150,hidden:true,align:'left',sortable:true},
                       {field:'Modifier',title:'Modifier',type:'string',width:130,hidden:true,align:'left'},
                       {field:'ModifyID',title:'ModifyID',type:'int',width:80,hidden:true,align:'left'}],
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
