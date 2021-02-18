<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/order/Carousel.js此处编写
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
    import extend from "@/extension/order/Carousel.js";
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
                    cnName: '轮播设置',
                    name: 'Carousel',
                    url: "/Carousel/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFields: {"Name":"","ImgPath":"","Url":"","Disable":"","Remark":""},
                editFormOptions: [[{"title":"名称","field":"Name"},
                               {"title":"图片地址","field":"ImgPath"}],
                              [{"title":"跳转链接","field":"Url"},
                               {"title":"禁用状态","field":"Disable","type":"switch"}],
                              [{"title":"备注","field":"Remark","colSize":12}]],
                searchFormFields: {"Name":"","ImgPath":"","Url":""},
                searchFormOptions: [[{"title":"名称","field":"Name"},{"title":"图片地址","field":"ImgPath"},{"title":"跳转链接","field":"Url"}]],
                columns: [{field:'Id',title:'Id',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Name',title:'名称',type:'string',width:120,align:'left',sortable:true},
                       {field:'ImgPath',title:'图片地址',type:'string',width:120,align:'left'},
                       {field:'Remark',title:'备注',type:'string',width:120,align:'left'},
                       {field:'Url',title:'跳转链接',type:'string',width:120,align:'left'},
                       {field:'Disable',title:'禁用状态',type:'bool',width:90,align:'left'},
                       {field:'CreateDate',title:'发生时间',type:'datetime',width:90,align:'left',sortable:true},
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
