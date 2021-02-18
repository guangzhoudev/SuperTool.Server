<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/order/TaskRecord.js此处编写
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
    import extend from "@/extension/order/TaskRecord.js";
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
                    cnName: '任务记录',
                    name: 'TaskRecord',
                    url: "/TaskRecord/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFields: {"TaskId":"","TaskName":"","TaskInfo":""},
                editFormOptions: [[{"title":"任务编号","field":"TaskId"}],
                              [{"title":"任务名称","field":"TaskName"}],
                              [{"title":"详细信息记录","field":"TaskInfo"}]],
                searchFormFields: {"TaskId":"","TaskName":"","TaskInfo":"","CreateDate":""},
                searchFormOptions: [[{"title":"任务编号","field":"TaskId","type":"like"},{"title":"任务名称","field":"TaskName","type":"like"}],[{"title":"详细信息记录","field":"TaskInfo","type":"like"},{"title":"创建时间","field":"CreateDate","type":"date"}]],
                columns: [{field:'Id',title:'Id',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'TaskId',title:'任务编号',type:'string',width:120,align:'left',sortable:true},
                       {field:'TaskName',title:'任务名称',type:'string',width:120,align:'left'},
                       {field:'TaskInfo',title:'详细信息记录',type:'string',width:220,align:'left'},
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
