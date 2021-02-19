<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/order/Shop.js此处编写
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
    import extend from "@/extension/order/Shop.js";
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
                    cnName: '店铺管理',
                    name: 'Shop',
                    url: "/Shop/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFields: {"CustomerName":"","ShopName":"","Contact":"","Type":"","BindTime":"","Address":""},
                editFormOptions: [[{"title":"公司名称","field":"CustomerName"},
                               {"title":"店铺名称","field":"ShopName"}],
                              [{"title":"联系人","field":"Contact"},
                               {"title":"店铺类型","field":"Type"}],
                              [{"title":"绑定时间","field":"BindTime","type":"datetime"},
                               {"title":"店铺地址","field":"Address"}]],
                searchFormFields: {"CustomerName":"","ShopName":"","Contact":"","Type":"","BindTime":"","Address":""},
                searchFormOptions: [[{"title":"公司名称","field":"CustomerName"},{"title":"店铺名称","field":"ShopName"},{"title":"联系人","field":"Contact"}],[{"title":"店铺类型","field":"Type"},{"title":"绑定时间","field":"BindTime","type":"datetime"},{"title":"店铺地址","field":"Address"}]],
                columns: [{field:'Id',title:'Id',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'CustomerName',title:'公司名称',type:'string',width:120,align:'left',sortable:true},
                       {field:'ShopName',title:'店铺名称',type:'string',width:120,align:'left'},
                       {field:'Contact',title:'联系人',type:'string',width:90,align:'left'},
                       {field:'Type',title:'店铺类型',type:'string',width:90,align:'left'},
                       {field:'BindTime',title:'绑定时间',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'Address',title:'店铺地址',type:'string',width:220,align:'left'},
                       {field:'CreateID',title:'创建人ID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'CreateDate',title:'创建时间',type:'datetime',width:90,align:'left',sortable:true},
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
