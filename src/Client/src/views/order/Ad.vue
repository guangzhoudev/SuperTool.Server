<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/order/Ad.js此处编写
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
    import extend from "@/extension/order/Ad.js";
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
                    cnName: '广告管理',
                    name: 'Ad',
                    url: "/Ad/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFields: {"Title":"","Contents":"","Url":"","AdImgPath":""},
                editFormOptions: [[{"title":"广告标题","field":"Title"}],
                              [{"title":"内容","field":"Contents"}],
                              [{"title":"网页链接","field":"Url"}],
                              [{"title":"广告图","field":"AdImgPath","type":"img"}]],
                searchFormFields: {"Title":"","Contents":"","Url":""},
                searchFormOptions: [[{"title":"广告标题","field":"Title"},{"title":"内容","field":"Contents"},{"title":"网页链接","field":"Url"}]],
                columns: [{field:'Id',title:'Id',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Title',title:'广告标题',type:'string',width:120,align:'left',sortable:true},
                       {field:'Contents',title:'内容',type:'string',width:120,align:'left'},
                       {field:'AdImgPath',title:'广告图',type:'img',width:120,align:'left'},
                       {field:'Url',title:'网页链接',type:'string',width:120,align:'left'},
                       {field:'CreateID',title:'CreateID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'CreateDate',title:'CreateDate',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'Creator',title:'Creator',type:'string',width:130,align:'left'},
                       {field:'ModifyDate',title:'ModifyDate',type:'datetime',width:90,hidden:true,align:'left',sortable:true},
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
