<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/order/SensitiveWordFilter.js此处编写
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
    import extend from "@/extension/order/SensitiveWordFilter.js";
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
                    cnName: '敏感词管理',
                    name: 'SensitiveWordFilter',
                    url: "/SensitiveWordFilter/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFields: {"FilterWord":"","NewWord":"","Lv":""},
                editFormOptions: [[{"title":"过滤词","field":"FilterWord"}],
                              [{"title":"替代词","field":"NewWord"}],
                              [{"title":"级别","field":"Lv"}]],
                searchFormFields: {"FilterWord":"","NewWord":"","Lv":""},
                searchFormOptions: [[{"title":"过滤词","field":"FilterWord"},{"title":"替代词","field":"NewWord"},{"title":"级别","field":"Lv"}]],
                columns: [{field:'Id',title:'Id',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'FilterWord',title:'过滤词',type:'string',width:120,align:'left',sortable:true},
                       {field:'NewWord',title:'替代词',type:'string',width:120,align:'left'},
                       {field:'Lv',title:'级别',type:'string',width:120,align:'left'},
                       {field:'CreateDate',title:'创建时间',type:'datetime',width:150,align:'left',sortable:true},
                       {field:'CreateID',title:'创建人ID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Creator',title:'创建人',type:'string',width:130,align:'left'},
                       {field:'ModifyID',title:'编辑人ID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Modifier',title:'编辑人',type:'string',width:130,hidden:true,align:'left'},
                       {field:'ModifyDate',title:'编辑时间',type:'datetime',width:150,hidden:true,align:'left',sortable:true}],
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
