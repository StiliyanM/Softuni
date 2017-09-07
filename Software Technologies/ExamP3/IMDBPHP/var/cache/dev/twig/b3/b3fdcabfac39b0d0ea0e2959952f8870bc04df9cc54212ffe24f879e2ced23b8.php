<?php

/* @Twig/layout.html.twig */
class __TwigTemplate_0ef46ff3e00be850b375145c4de69a72941605b1b30816a42d1a36aa92bc080f extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'head' => array($this, 'block_head'),
            'body' => array($this, 'block_body'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_c8c951ed3e941cea7d22cac8217e809dd11089932b71dce3f8cba66997e3e1bb = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_c8c951ed3e941cea7d22cac8217e809dd11089932b71dce3f8cba66997e3e1bb->enter($__internal_c8c951ed3e941cea7d22cac8217e809dd11089932b71dce3f8cba66997e3e1bb_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/layout.html.twig"));

        $__internal_868b2b0f721187b66164a68a26babd7bc957d912bce6a00ed19fdaf18ebcf89a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_868b2b0f721187b66164a68a26babd7bc957d912bce6a00ed19fdaf18ebcf89a->enter($__internal_868b2b0f721187b66164a68a26babd7bc957d912bce6a00ed19fdaf18ebcf89a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/layout.html.twig"));

        // line 1
        echo "<!DOCTYPE html>
<html>
    <head>
        <meta charset=\"";
        // line 4
        echo twig_escape_filter($this->env, $this->env->getCharset(), "html", null, true);
        echo "\" />
        <meta name=\"robots\" content=\"noindex,nofollow\" />
        <meta name=\"viewport\" content=\"width=device-width,initial-scale=1\" />
        <title>";
        // line 7
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
        <link rel=\"icon\" type=\"image/png\" href=\"";
        // line 8
        echo twig_include($this->env, $context, "@Twig/images/favicon.png.base64");
        echo "\">
        <style>";
        // line 9
        echo twig_include($this->env, $context, "@Twig/exception.css.twig");
        echo "</style>
        ";
        // line 10
        $this->displayBlock('head', $context, $blocks);
        // line 11
        echo "    </head>
    <body>
        <header>
            <div class=\"container\">
                <h1 class=\"logo\">";
        // line 15
        echo twig_include($this->env, $context, "@Twig/images/symfony-logo.svg");
        echo " Symfony Exception</h1>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/doc\">
                        <span class=\"icon\">";
        // line 19
        echo twig_include($this->env, $context, "@Twig/images/icon-book.svg");
        echo "</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Docs
                    </a>
                </div>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/support\">
                        <span class=\"icon\">";
        // line 26
        echo twig_include($this->env, $context, "@Twig/images/icon-support.svg");
        echo "</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Support
                    </a>
                </div>
            </div>
        </header>

        ";
        // line 33
        $this->displayBlock('body', $context, $blocks);
        // line 34
        echo "        ";
        echo twig_include($this->env, $context, "@Twig/base_js.html.twig");
        echo "
    </body>
</html>
";
        
        $__internal_c8c951ed3e941cea7d22cac8217e809dd11089932b71dce3f8cba66997e3e1bb->leave($__internal_c8c951ed3e941cea7d22cac8217e809dd11089932b71dce3f8cba66997e3e1bb_prof);

        
        $__internal_868b2b0f721187b66164a68a26babd7bc957d912bce6a00ed19fdaf18ebcf89a->leave($__internal_868b2b0f721187b66164a68a26babd7bc957d912bce6a00ed19fdaf18ebcf89a_prof);

    }

    // line 7
    public function block_title($context, array $blocks = array())
    {
        $__internal_c945ed8caa06214399dcc258aae5b09a73e88da035e2ec8d1d142608f839c032 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_c945ed8caa06214399dcc258aae5b09a73e88da035e2ec8d1d142608f839c032->enter($__internal_c945ed8caa06214399dcc258aae5b09a73e88da035e2ec8d1d142608f839c032_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_8cb0fd1d1d0feccf6d5f2c70731981443ecea0a4c101d6b9a60f8b193f5b732b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_8cb0fd1d1d0feccf6d5f2c70731981443ecea0a4c101d6b9a60f8b193f5b732b->enter($__internal_8cb0fd1d1d0feccf6d5f2c70731981443ecea0a4c101d6b9a60f8b193f5b732b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        
        $__internal_8cb0fd1d1d0feccf6d5f2c70731981443ecea0a4c101d6b9a60f8b193f5b732b->leave($__internal_8cb0fd1d1d0feccf6d5f2c70731981443ecea0a4c101d6b9a60f8b193f5b732b_prof);

        
        $__internal_c945ed8caa06214399dcc258aae5b09a73e88da035e2ec8d1d142608f839c032->leave($__internal_c945ed8caa06214399dcc258aae5b09a73e88da035e2ec8d1d142608f839c032_prof);

    }

    // line 10
    public function block_head($context, array $blocks = array())
    {
        $__internal_5b7a29626f7da0b788f42940d687fd634cfe79842a6b7ae0f1a4cdf8f3ca98c7 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_5b7a29626f7da0b788f42940d687fd634cfe79842a6b7ae0f1a4cdf8f3ca98c7->enter($__internal_5b7a29626f7da0b788f42940d687fd634cfe79842a6b7ae0f1a4cdf8f3ca98c7_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_25ee857b607135c33499e9848c82b8a39a7a6aa628277869f19a7693029964fb = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_25ee857b607135c33499e9848c82b8a39a7a6aa628277869f19a7693029964fb->enter($__internal_25ee857b607135c33499e9848c82b8a39a7a6aa628277869f19a7693029964fb_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        
        $__internal_25ee857b607135c33499e9848c82b8a39a7a6aa628277869f19a7693029964fb->leave($__internal_25ee857b607135c33499e9848c82b8a39a7a6aa628277869f19a7693029964fb_prof);

        
        $__internal_5b7a29626f7da0b788f42940d687fd634cfe79842a6b7ae0f1a4cdf8f3ca98c7->leave($__internal_5b7a29626f7da0b788f42940d687fd634cfe79842a6b7ae0f1a4cdf8f3ca98c7_prof);

    }

    // line 33
    public function block_body($context, array $blocks = array())
    {
        $__internal_44f13c5a2a8cbc6625d28aea8fb003c33b3b290127de00130193eec942b22560 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_44f13c5a2a8cbc6625d28aea8fb003c33b3b290127de00130193eec942b22560->enter($__internal_44f13c5a2a8cbc6625d28aea8fb003c33b3b290127de00130193eec942b22560_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_71a1c626c81c032431579d4c8d5fb1114a0afde5910a9d11bc7b63ea2f7d3230 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_71a1c626c81c032431579d4c8d5fb1114a0afde5910a9d11bc7b63ea2f7d3230->enter($__internal_71a1c626c81c032431579d4c8d5fb1114a0afde5910a9d11bc7b63ea2f7d3230_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        
        $__internal_71a1c626c81c032431579d4c8d5fb1114a0afde5910a9d11bc7b63ea2f7d3230->leave($__internal_71a1c626c81c032431579d4c8d5fb1114a0afde5910a9d11bc7b63ea2f7d3230_prof);

        
        $__internal_44f13c5a2a8cbc6625d28aea8fb003c33b3b290127de00130193eec942b22560->leave($__internal_44f13c5a2a8cbc6625d28aea8fb003c33b3b290127de00130193eec942b22560_prof);

    }

    public function getTemplateName()
    {
        return "@Twig/layout.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  137 => 33,  120 => 10,  103 => 7,  88 => 34,  86 => 33,  76 => 26,  66 => 19,  59 => 15,  53 => 11,  51 => 10,  47 => 9,  43 => 8,  39 => 7,  33 => 4,  28 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("<!DOCTYPE html>
<html>
    <head>
        <meta charset=\"{{ _charset }}\" />
        <meta name=\"robots\" content=\"noindex,nofollow\" />
        <meta name=\"viewport\" content=\"width=device-width,initial-scale=1\" />
        <title>{% block title %}{% endblock %}</title>
        <link rel=\"icon\" type=\"image/png\" href=\"{{ include('@Twig/images/favicon.png.base64') }}\">
        <style>{{ include('@Twig/exception.css.twig') }}</style>
        {% block head %}{% endblock %}
    </head>
    <body>
        <header>
            <div class=\"container\">
                <h1 class=\"logo\">{{ include('@Twig/images/symfony-logo.svg') }} Symfony Exception</h1>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/doc\">
                        <span class=\"icon\">{{ include('@Twig/images/icon-book.svg') }}</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Docs
                    </a>
                </div>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/support\">
                        <span class=\"icon\">{{ include('@Twig/images/icon-support.svg') }}</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Support
                    </a>
                </div>
            </div>
        </header>

        {% block body %}{% endblock %}
        {{ include('@Twig/base_js.html.twig') }}
    </body>
</html>
", "@Twig/layout.html.twig", "C:\\Users\\ASUS\\ExamP3\\IMDBPHP\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\TwigBundle\\Resources\\views\\layout.html.twig");
    }
}
