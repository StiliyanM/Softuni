<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_09886c37796d81d574b2448cf2a22ea32da8dad546b69f22c376ce19a869ce97 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_5efa6f649cac5511fde9596725ad13accb77dada689de59b60f2250d45c7b2a4 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_5efa6f649cac5511fde9596725ad13accb77dada689de59b60f2250d45c7b2a4->enter($__internal_5efa6f649cac5511fde9596725ad13accb77dada689de59b60f2250d45c7b2a4_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $__internal_506dc83cc0df2e789841fec17dc2a0ee84df9166409474b56ae91c34b64a73f0 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_506dc83cc0df2e789841fec17dc2a0ee84df9166409474b56ae91c34b64a73f0->enter($__internal_506dc83cc0df2e789841fec17dc2a0ee84df9166409474b56ae91c34b64a73f0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_5efa6f649cac5511fde9596725ad13accb77dada689de59b60f2250d45c7b2a4->leave($__internal_5efa6f649cac5511fde9596725ad13accb77dada689de59b60f2250d45c7b2a4_prof);

        
        $__internal_506dc83cc0df2e789841fec17dc2a0ee84df9166409474b56ae91c34b64a73f0->leave($__internal_506dc83cc0df2e789841fec17dc2a0ee84df9166409474b56ae91c34b64a73f0_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_21ce3b17d5e627d4d395061e729f902cf8ec3aedcdf68dd4dd6329d380fbffa5 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_21ce3b17d5e627d4d395061e729f902cf8ec3aedcdf68dd4dd6329d380fbffa5->enter($__internal_21ce3b17d5e627d4d395061e729f902cf8ec3aedcdf68dd4dd6329d380fbffa5_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        $__internal_fde04d08a8b5ed0f1e4139df4ed5a7b6867bdd0547d53a38761d49e59e832fc4 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_fde04d08a8b5ed0f1e4139df4ed5a7b6867bdd0547d53a38761d49e59e832fc4->enter($__internal_fde04d08a8b5ed0f1e4139df4ed5a7b6867bdd0547d53a38761d49e59e832fc4_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_fde04d08a8b5ed0f1e4139df4ed5a7b6867bdd0547d53a38761d49e59e832fc4->leave($__internal_fde04d08a8b5ed0f1e4139df4ed5a7b6867bdd0547d53a38761d49e59e832fc4_prof);

        
        $__internal_21ce3b17d5e627d4d395061e729f902cf8ec3aedcdf68dd4dd6329d380fbffa5->leave($__internal_21ce3b17d5e627d4d395061e729f902cf8ec3aedcdf68dd4dd6329d380fbffa5_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_bcb711abc99a066e0d66bdb18c6f910a18a5809ac534fa101915796eafba04f6 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_bcb711abc99a066e0d66bdb18c6f910a18a5809ac534fa101915796eafba04f6->enter($__internal_bcb711abc99a066e0d66bdb18c6f910a18a5809ac534fa101915796eafba04f6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_bef5bbd1a606a168c0bc9ce9d317ce0b0cb3f12ac6bef992d71634e67dcf5547 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_bef5bbd1a606a168c0bc9ce9d317ce0b0cb3f12ac6bef992d71634e67dcf5547->enter($__internal_bef5bbd1a606a168c0bc9ce9d317ce0b0cb3f12ac6bef992d71634e67dcf5547_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_bef5bbd1a606a168c0bc9ce9d317ce0b0cb3f12ac6bef992d71634e67dcf5547->leave($__internal_bef5bbd1a606a168c0bc9ce9d317ce0b0cb3f12ac6bef992d71634e67dcf5547_prof);

        
        $__internal_bcb711abc99a066e0d66bdb18c6f910a18a5809ac534fa101915796eafba04f6->leave($__internal_bcb711abc99a066e0d66bdb18c6f910a18a5809ac534fa101915796eafba04f6_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_d494d8bd80226cf4241ab3e3e257eca76762a370e69256c596756d6ffbc37f3a = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_d494d8bd80226cf4241ab3e3e257eca76762a370e69256c596756d6ffbc37f3a->enter($__internal_d494d8bd80226cf4241ab3e3e257eca76762a370e69256c596756d6ffbc37f3a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_52bd87570e468556fe9f6b92bf07ffba2b45419f8564bb653093b7965b890c30 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_52bd87570e468556fe9f6b92bf07ffba2b45419f8564bb653093b7965b890c30->enter($__internal_52bd87570e468556fe9f6b92bf07ffba2b45419f8564bb653093b7965b890c30_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_52bd87570e468556fe9f6b92bf07ffba2b45419f8564bb653093b7965b890c30->leave($__internal_52bd87570e468556fe9f6b92bf07ffba2b45419f8564bb653093b7965b890c30_prof);

        
        $__internal_d494d8bd80226cf4241ab3e3e257eca76762a370e69256c596756d6ffbc37f3a->leave($__internal_d494d8bd80226cf4241ab3e3e257eca76762a370e69256c596756d6ffbc37f3a_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  94 => 13,  85 => 12,  71 => 7,  68 => 6,  59 => 5,  42 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
", "@WebProfiler/Collector/router.html.twig", "C:\\Users\\ASUS\\ExamP3\\IMDBPHP\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\router.html.twig");
    }
}
