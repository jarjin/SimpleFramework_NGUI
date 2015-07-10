require "Common/define"

PromptCtrl = {};
local this = PromptCtrl;

local panel;
local prompt;
local transform;
local gameObject;

--构建函数--
function PromptCtrl.New()
	warn("PromptCtrl.New--->>");
	return this;
end

function PromptCtrl.Awake()
	warn("PromptCtrl.Awake--->>");
	PanelManager:CreatePanel('Prompt', this.OnCreate);
end

--启动事件--
function PromptCtrl.OnCreate(obj)
	gameObject = obj;
	transform = obj.transform;

	panel = transform:GetComponent('UIPanel');
	prompt = transform:GetComponent('LuaBehaviour');
	warn("Start lua--->>"..gameObject.name);

	this.InitPanel();	--初始化面板--
	prompt:AddClick(PromptPanel.btnOpen, this.OnClick);
end

--初始化面板--
function PromptCtrl.InitPanel()
	panel.depth = 1;	--设置纵深--
	local parent = PromptPanel.gridParent;
	local itemPrefab = prompt:GetGameObject('PromptItem');
	for i = 1, 100 do
		local go = newobject(itemPrefab);
		go.name = tostring(i);
		go.transform.parent = parent;
		go.transform.localScale = Vector3.one;
		go.transform.localPosition = Vector3.zero;

		local goo = go.transform:FindChild('Label');
		goo:GetComponent('UILabel').text = i;
	end
	local grid = parent:GetComponent('UIGrid');
	grid:Reposition();
	grid.repositionNow = true;
	parent:GetComponent('WrapGrid'):InitGrid();
end

--单击事件--
function PromptCtrl.OnClick(go)
    local buffer = ByteBuffer.New();
    buffer:WriteShort(Login);
    buffer:WriteString("ffff我的ffffQ靈uuu");
    buffer:WriteInt(200);
    NetManager:SendMessage(buffer);
	warn("OnClick---->>>"..go.name);
end

--关闭事件--
function PromptCtrl.Close()
	PanelManager:ClosePanel(CtrlName.Prompt);
end