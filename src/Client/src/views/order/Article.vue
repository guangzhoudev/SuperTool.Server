<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/order/Article.js此处编写
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
    import extend from "@/extension/order/Article.js";
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
                    cnName: '文章管理',
                    name: 'Article',
                    url: "/Article/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFields: {"Types":"","Title":"","Contents":"","TitlePage":"","Video":""},
                editFormOptions: [[{"dataKey":"ArticleOrVideo","data":[],"title":"分类","field":"Types","colSize":12,"type":"select"}],
                              [{"title":"标题","field":"Title","colSize":12}],
                              [{"title":"内容","field":"Contents","colSize":12,"type":"textarea"}],
                              [{"title":"封面","field":"TitlePage","colSize":6,"type":"img"},
                               {"title":"视频","field":"Video","colSize":6,"type":"file"}]],
                searchFormFields: {"Types":"","Title":"","Contents":"","CreateDate":""},
                searchFormOptions: [[{"dataKey":"ArticleOrVideo","data":[],"title":"分类","field":"Types","type":"select"},{"title":"标题","field":"Title"}],[{"title":"内容","field":"Contents"},{"title":"创建时间","field":"CreateDate"}]],
                columns: [{field:'Id',title:'Id',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Types',title:'分类',type:'string',bind:{ key:'ArticleOrVideo',data:[]},width:90,align:'left',sortable:true},
                       {field:'Title',title:'标题',type:'string',width:120,align:'left'},
                       {field:'Contents',title:'内容',type:'string',width:150,align:'left'},
                       {field:'TitlePage',title:'封面',type:'img',width:120,align:'left'},
                       {field:'Video',title:'视频',type:'file',width:120,align:'left'},
                       {field:'CreateID',title:'创建人ID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'CreateDate',title:'创建时间',type:'datetime',width:120,align:'left',sortable:true},
                       {field:'Creator',title:'创建人',type:'string',width:120,align:'left'},
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
