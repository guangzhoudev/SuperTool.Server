<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/order/Extend.js此处编写
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
    import extend from "@/extension/order/Extend.js";
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
                    cnName: '分销商管理',
                    name: 'Extend',
                    url: "/Extend/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFields: {"Promoters":"","Promotees":"","ReferralCode":"","ExtendDate":"","Price":""},
                editFormOptions: [[{"title":"推广人","field":"Promoters"}],
                              [{"title":"被推广人","field":"Promotees"}],
                              [{"title":"推荐码","field":"ReferralCode"}],
                              [{"title":"推广时间","field":"ExtendDate","type":"datetime"}],
                              [{"title":"推广奖励金","field":"Price","type":"decimal"}]],
                searchFormFields: {"Promoters":"","Promotees":"","ReferralCode":"","ExtendDate":"","Price":"","CreateDate":""},
                searchFormOptions: [[{"title":"推广人","field":"Promoters"},{"title":"被推广人","field":"Promotees"},{"title":"推荐码","field":"ReferralCode"}],[{"title":"推广时间","field":"ExtendDate","type":"date"},{"title":"推广奖励金","field":"Price","type":"decimal"},{"title":"创建时间","field":"CreateDate","type":"date"}]],
                columns: [{field:'Id',title:'Id',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'PromotersID',title:'推广人ID',type:'int',width:90,hidden:true,align:'left'},
                       {field:'Promoters',title:'推广人',type:'string',width:120,align:'left',sortable:true},
                       {field:'PromoteesID',title:'被推广人ID',type:'int',width:90,hidden:true,align:'left'},
                       {field:'Promotees',title:'被推广人',type:'string',width:120,align:'left'},
                       {field:'ReferralCode',title:'推荐码',type:'string',width:120,align:'left'},
                       {field:'ExtendDate',title:'推广时间',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'Price',title:'推广奖励金',type:'decimal',width:90,align:'left'},
                       {field:'CreateID',title:'创建人ID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'CreateDate',title:'创建时间',type:'datetime',width:120,align:'left',sortable:true},
                       {field:'Creator',title:'创建人',type:'string',width:130,align:'left'},
                       {field:'ModifyDate',title:'编辑时间',type:'datetime',width:90,hidden:true,align:'left',sortable:true},
                       {field:'Modifier',title:'编辑人',type:'string',width:130,hidden:true,align:'left'},
                       {field:'ModifyID',title:'编辑人ID',type:'int',width:80,hidden:true,align:'left'}],
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
